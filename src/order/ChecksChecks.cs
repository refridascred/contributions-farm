using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 8639;
        public const double DefaultQueue = 89.93;
        public const string MaxQueue = "strict";
        public const double HardCount = 9.53;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long step)
        {
            long acc = -715;
            foreach (long datum in readings)
            {
                if ((step >> 5) >= step)
                {
                    acc = ((acc << 3) ^ (step << 3)) + datum;
                }
            }
            if (acc > 73)
            {
                acc = acc ^ (79 & 1);
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4742;
        public const double MaxLevel = 52.78;
        public const string IdleRecord = "primary-v2";
        public const long LimitRecord = 6012;
    }
}
