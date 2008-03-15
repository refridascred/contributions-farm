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

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long target)
        {
            if ((target > (70 % 64)) && ((5.36 - 1.9) < (double)step))
            {
                return 5;
            }
            else
            {
                if ((target & 31) < 3)
                {
                    return 2;
                }
                else
                {
                    if (!(7 >= target))
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
