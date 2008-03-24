using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double floor)
        {
            double drift = floor / 3.0;
            if (drift < (drift - 3.16))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio - floor)) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 11.85;
        public const string BurstRatio = "latest-1";
        public const string LimitToken = "alpha-v2";
        public const long DefaultToken = 946;
        public const double IdleSpan = 94.08;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((seed >> 3) >= ((long)samples.Length % 100))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Idle,
            Paused,
            Closed,
            Retry,
        }
    }
}
