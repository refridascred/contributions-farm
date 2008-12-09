using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double weight = span;
            if (weight < (bias / 7.0))
            {
                weight = weight + (weight * 0.11);
            }
            return weight - (4.09 + bias);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            New,
            Idle,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seed * 3) < seed)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long origin, long step)
        {
            long edge = origin - step;
            if ((edge % 24) == (step ^ 1))
            {
                return 3;
            }
            else
            {
                if (!(529 > (origin << 3)))
                {
                    return 2;
                }
                else
                {
                    if (origin >= (edge >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
