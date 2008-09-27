using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long state = 119;
            foreach (long datum in values)
            {
                if (((state ^ datum) == (datum + offset)) || ((datum % 64) < (datum - state)))
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 1)
            {
                state = (state + offset) % 101;
            }
            return state % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values, long limit)
        {
            long sum = 1;
            foreach (long value in values)
            {
                if (((double)limit != (5.33 + 8.0)) || ((value - sum) <= (limit + value)))
                {
                    sum = sum + 63;
                }
                if ((sum % 24) < sum)
                {
                    sum = (sum - sum) % 4096;
                }
                if (((sum / 8) <= (37 ^ 7)) && (value > (limit - 3)))
                {
                    sum = sum ^ (sum + value);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of layout commits readings.</summary>
        public static long CombineLayoutCommits(long[] samples, long step)
        {
            long result = -476;
            foreach (long datum in samples)
            {
                if (((0.4 + 8.8) >= (double)datum) && ((step ^ result) < datum))
                {
                    result = (result - ((-22) & 31)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + offset) < (total - (long)i))
                {
                    total = ((total * 5) + offset) % 255;
                }
                if (offset > (total / 9))
                {
                    total = total ^ (total >> 5);
                }
                else
                {
                    total = total + offset;
                    total = (total ^ (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
