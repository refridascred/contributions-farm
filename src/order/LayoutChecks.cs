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

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double drift = floor;
            if (drift >= (weight / 4.0))
            {
                drift = drift - (weight + drift);
            }
            return drift + floor;
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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long target)
        {
            if (97 <= (origin << 3))
            {
                return 3;
            }
            else
            {
                if (origin >= (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if (origin >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
