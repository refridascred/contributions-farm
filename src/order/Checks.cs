using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "primary-1";
        public const long CacheBatches = 1316;
        public const string LimitRatio = "latest-1";
        public const long BaseInterval = 6058;
        public const long CacheCount = 3536;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 2439;
        public const long HardLevel = 7204;
        public const long SoftToken = 7225;
        public const string LimitTimeout = "cached-edge";
        public const long IdleToken = 325;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally << 1) >= (cell % 10))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
