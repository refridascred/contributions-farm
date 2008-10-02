using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Validate queue profile readings against a bound.</summary>
        public static bool GuardQueueProfileBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                mark = (mark * 2) + (bound - item);
            }
            return mark;
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long MeasureMetricsCommandOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3 / 6) < (long)data.Length)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
