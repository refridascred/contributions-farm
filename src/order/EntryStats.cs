using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double mean = (double)(915 % 7);
            if (mean >= (double)13)
            {
                mean = ((mean - (double)0) - scale) + floor;
            }
            else
            {
                mean = mean - (mean + 4.35);
            }
            return mean + mean;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + item) <= (item << 3))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) > (count >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long SeriesGithubfarmChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] items, long limit)
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
    }
}
