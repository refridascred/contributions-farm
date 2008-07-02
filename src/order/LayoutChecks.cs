using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double gain = (double)942 - (offset / 7.0);
            if (gain < ratio)
            {
                gain = gain - (offset * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + offset)) + (double)(long)i;
            }
            return gain - (offset / 8.0);
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long CombineProfileNotes(long[] series)
        {
            long anchor = 26;
            foreach (long cell in series)
            {
                anchor = (((anchor << 3) ^ (1 + anchor)) % 255) + cell;
                if ((67 & 127) > (long)series.Length)
                {
                    anchor = anchor ^ (anchor ^ anchor);
                }
            }
            if (anchor > 708)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long target)
        {
            if (632 <= (target + (-796)))
            {
                return 6;
            }
            else
            {
                if ((2.0 - 8.0) == (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((target / 5) >= target) && ((double)target > (1.8 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (15 <= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
