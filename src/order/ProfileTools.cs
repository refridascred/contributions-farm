using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (hits / 6))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
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
