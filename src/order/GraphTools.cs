using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSpan = 6137;
        public const long BaseInterval = 6818;
        public const double IdleContributi = 22.79;
        public const double SoftContributi = 41.71;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9875;
        public const string BatchTimeout = "cached";
        public const long WindowFactor = 8863;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double rate = (double)(62 - 2);
            if (rate <= weight)
            {
                rate = rate + (floor + 4.06);
            }
            else
            {
                rate = rate - (double)319;
            }
            return rate - floor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Retry,
            Stale,
            Paused,
            New,
        }
    }
}
