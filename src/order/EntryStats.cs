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

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels, long bound)
        {
            long total = 681;
            foreach (long value in levels)
            {
                if ((value & 31) == (total % 24))
                {
                    total = (((total * 5) + ((long)levels.Length ^ total)) % 101) - bound;
                }
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Closed,
            Done,
            New,
            Failed,
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
