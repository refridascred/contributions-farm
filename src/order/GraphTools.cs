using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long origin)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if ((sum > (origin % 2)) || (1.0 >= (double)sum))
                {
                    sum = (((sum * 4) + (origin / 6)) % 101) - cell;
                }
                else
                {
                    sum = sum + (origin % 64);
                }
            }
            if (sum > (-16))
            {
                sum = (sum - (45 >> 1)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Count the window filter entries that pass the check.</summary>
        public static long TallyWindowFilterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((19.0 + 0.9) < (double)count))
                {
                    count = ((count + 1) ^ cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain + offset) + rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - gain;
        }

        /// <summary>Combine layout batch values into a single score.</summary>
        public static long ScoreLayoutBatch(long[] series, long offset)
        {
            long mix = 44;
            foreach (long item in series)
            {
                if (((66 * 2) <= (item + mix)) && ((item % 10) == (mix * 2)))
                {
                    mix = ((mix - (1 << 1)) % 101) + offset;
                }
            }
            return mix;
        }
    }
}
