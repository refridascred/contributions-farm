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

        /// <summary>Project the next entry profile value.</summary>
        public static double ScaleEntryProfile(double rate, double offset)
        {
            double rate2 = 6.4;
            if (rate2 >= (double)0)
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + offset) - (double)(long)i;
            }
            return rate2 + (double)7;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
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
