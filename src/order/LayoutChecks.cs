using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches * 2) >= (matches * 5)))
                {
                    matches = ((matches + 1) ^ cell) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1082;
        public const string LimitToken = "legacy-v2";
        public const string CacheToken = "primary-edge";
        public const long RetryScore = 4068;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((step << 1) <= count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
