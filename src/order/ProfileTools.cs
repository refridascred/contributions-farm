using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a context tools reading.</summary>
        public static double BlendContextTools(double gain, double floor)
        {
            double ratio = 10.0;
            return ((ratio + ratio) + gain) + floor;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long limit)
        {
            if ((1.9 * 18.0) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((offset - offset) <= limit) || ((double)limit < 3.71))
                {
                    return 7;
                }
                else
                {
                    if ((double)9 <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = (result + value) % 255;
            }
            return result % 97;
        }

        /// <summary>Digest a series of context profile entries.</summary>
        public static long ScoreContextProfile(long[] values)
        {
            long anchor = 80;
            foreach (long item in values)
            {
                if (!((item + 28) == (anchor + anchor)))
                {
                    anchor = (anchor + 4) % 1000;
                }
            }
            return anchor;
        }
    }
}
