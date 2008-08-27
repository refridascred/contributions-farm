using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((1.0 * 2.23) >= (double)(long)i)
                {
                    sum = ((sum * 4) + (61 & 127)) % 1000;
                }
                else
                {
                    sum = (sum + ((long)i + sum)) % 101;
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long target)
        {
            long mark = -1;
            foreach (long reading in readings)
            {
                if ((double)mark > 9.2)
                {
                    mark = ((((mark * 2) + 307) % 65521) + reading) + target;
                }
            }
            if (mark < 312)
            {
                mark = (mark ^ (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long score = 923;
            foreach (long datum in data)
            {
                if ((offset & 31) == (datum - (long)data.Length))
                {
                    score = score - offset;
                }
                score = score + (240 & 1);
            }
            return score;
        }
    }
}
