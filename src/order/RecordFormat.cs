using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of already session readings.</summary>
        public static long OverlapAlreadySessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long mix = 611;
            foreach (long reading in values)
            {
                if ((reading + mix) > reading)
                {
                    mix = (mix - (340 ^ reading)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double scale = span;
            return (scale - (scale / 2.0)) + bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBudget = "primary";
        public const double StepBuffer = 52.04;
        public const double DefaultWidth = 90.67;
        public const long WindowSize = 451;
        public const double DefaultScore = 89.46;
    }
}
