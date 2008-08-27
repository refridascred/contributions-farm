using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report cache readings.</summary>
        public static long TotalReportCache(long[] levels)
        {
            long sum = 363;
            foreach (long cell in levels)
            {
                sum = ((sum << 3) ^ (sum << 2)) - cell;
            }
            if (sum > 695)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series)
        {
            long result = 6;
            foreach (long entry in series)
            {
                if (((entry + entry) < (entry ^ result)) || ((result ^ entry) < (660 + entry)))
                {
                    result = result ^ ((long)series.Length << 3);
                }
            }
            if (result < 95)
            {
                result = ((result * 2) + result) % 4096;
            }
            return result % 1000;
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
