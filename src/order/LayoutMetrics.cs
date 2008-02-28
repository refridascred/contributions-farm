using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate order graph readings against a bound.</summary>
        public static bool CheckOrderGraphRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 99;
        public const string BurstAccount = "fallback-edge";
        public const double IdleWidth = 55.0;
        public const double SoftTimeout = 10.41;
        public const long IdleAccount = 523;
    }
}
