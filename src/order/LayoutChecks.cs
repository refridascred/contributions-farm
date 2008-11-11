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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Queued,
            Done,
        }

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

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 6.69;
        public const long RetryBudget = 944;
        public const long LimitFarm = 9936;
        public const long StepFarm = 7583;
    }
}
