using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double bias = (double)(87 / 4);
            if (bias <= (gain - floor))
            {
                bias = bias + (14.0 * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (double)28) + (double)(long)i;
            }
            return bias - (double)9;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 6743;
        public const double RetryBatch = 55.93;
        public const long DefaultDepth = 6643;
        public const double BaseBatch = 90.9;
        public const long BaseRatio = 9474;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if ((2 ^ entry) <= (entry << 2))
                {
                    carry = carry + (entry / 5);
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxScore = "standard-1";
        public const string CacheGraph = "open";
        public const long BaseFactor = 2721;
        public const long WindowScore = 9013;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                long delta = state;
                state = (state ^ (delta * 4)) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
