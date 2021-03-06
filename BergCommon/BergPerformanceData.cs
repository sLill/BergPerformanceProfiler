﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Management;
using System.Diagnostics;

namespace BergCommon
{
    [Serializable]
    public abstract class BergPerformanceData
    {
        #region Member Variables..
        [NonSerialized]
        private Stopwatch _PerformanceTimer = new Stopwatch();
        #endregion Member Variables..

        #region Properties..
        public long ElapsedTime { get; private set; }

        public string ParentProcessName { get; protected set; }

        public Guid PerformanceDataId { get; protected set; }

        public string SystemName { get; protected set; }

        public Dictionary<string, PerformanceWatch> PerformanceWatchCollection { get; set; }
        #endregion Properties..

        #region Enums..
        public enum CookingType
        {
            PERF_100NSEC_TIMER_INV,
            PERF_100NSEC_TIMER
        }
        #endregion Enums..

        #region Constructors..
        #region BergPerformanceData
        protected BergPerformanceData()
        {
            PerformanceDataId = Guid.NewGuid();
            _PerformanceTimer = new Stopwatch();
            PerformanceWatchCollection = new Dictionary<string, PerformanceWatch>();
        }
        #endregion BergPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        public virtual void Initialize()
        {
            _PerformanceTimer.Start();
        }
        #endregion Initialize

        #region RefreshPerformanceData
        public virtual void RefreshPerformanceData(object state)
        {
            ElapsedTime = _PerformanceTimer.ElapsedMilliseconds;
        }
        #endregion RefreshPerformanceData

        #region GetPerfValueFromRaw
        /// <summary>
        /// PERF_100NSEC_TIMER_INV algorithm.
        /// </summary>
        /// <param name="dataPointNew"></param>
        /// <param name="dataPointOld"></param>
        /// <param name="dataPointTimeStampNew"></param>
        /// <param name="dataPointTimeStampOld"></param>
        /// <returns></returns>
        protected static string GetPerfValueFromRaw(CookingType cookingType, long dataPointOld, long dataPointNew, UInt64 dataPointTimeStampOld, UInt64 dataPointTimeStampNew)
        {
            string Result = string.Empty;

            double DataDifference = (dataPointNew - dataPointOld);
            double TimeDifference = (dataPointTimeStampNew - dataPointTimeStampOld);
            try
            {
                switch (cookingType)
                {
                    case CookingType.PERF_100NSEC_TIMER_INV:
                        double UsageRawInv = (1 - (DataDifference / TimeDifference)) * 100;
                        Result = (UsageRawInv >= 0.5) ? Convert.ToInt32(Math.Ceiling(UsageRawInv)).ToString() : "0";
                        break;
                    case CookingType.PERF_100NSEC_TIMER:
                        double UsageRaw = (DataDifference / TimeDifference) * 100;
                        Result = (UsageRaw >= 0.5) ? Convert.ToInt32(Math.Ceiling(UsageRaw)).ToString() : "0";
                        break;
                }

            }
            catch { }

            return Result;
        }
        #endregion GetPerfValueFromRaw

        #region Deserialize
        public static object Deserialize(byte[] data)
        {
            using (var memoryStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                memoryStream.Write(data, 0, data.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);

                return binaryFormatter.Deserialize(memoryStream);
            }
        }
        #endregion Deserialize

        #region Serialize
        public byte[] Serialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, this);
                return memoryStream.ToArray();
            }
        }
        #endregion Serialize
        #endregion Methods..
    }
}
