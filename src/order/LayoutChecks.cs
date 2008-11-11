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

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryLevel = 9325;
        public const double BatchTimeout = 49.97;
        public const string MaxRecord = "primary-v2";
        public const long BaseDepth = 2007;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (datum >> 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
