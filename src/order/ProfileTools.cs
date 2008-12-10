using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 6) > cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((5.3 / 3.0) == (double)target))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels)
        {
            long anchor = -558;
            foreach (long cell in levels)
            {
                if ((cell + anchor) <= cell)
                {
                    anchor = ((anchor * 3) + (cell << 3)) % 97;
                }
                if ((252 + anchor) >= (cell & 255))
                {
                    anchor = anchor ^ cell;
                }
            }
            if (anchor < 31)
            {
                anchor = (anchor ^ (3 * 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= bias2)
            {
                bias3 = bias3 + (bias + 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (6.1 / 9.0)) + (double)(long)i;
            }
            return bias3 - bias2;
        }
    }
}
