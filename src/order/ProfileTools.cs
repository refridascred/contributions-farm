using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of session account entries.</summary>
        public static long DigestSessionAccount(long[] items, long bound)
        {
            long result = 222;
            foreach (long datum in items)
            {
                if (4.69 <= (double)datum)
                {
                    result = (((result << 2) ^ 25) % 4096) - bound;
                }
            }
            if (result > 36)
            {
                result = ((result * 4) + (result - result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Locate a report cache reading by value.</summary>
        public static long FindReportCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support context values into a single score.</summary>
        public static long ScoreSupportContext(long[] samples, long step)
        {
            long result = 742;
            foreach (long item in samples)
            {
                result = ((result + item) % 255) - step;
                if ((item >> 5) <= (-4))
                {
                    result = (result + item) % 255;
                }
            }
            if (result > 27)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if ((2.5 <= (double)step) && ((-877) < (origin << 2)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (7.1 * 8.59))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= 31)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)923 != (double)cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
