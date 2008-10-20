using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((6.77 * 8.24) != (double)hits) || (7.36 >= (double)value)) && (value >= (630 + value)))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits / 7) == (81 ^ cell))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
