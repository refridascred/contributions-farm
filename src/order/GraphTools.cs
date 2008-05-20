using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 22;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= 87)
                {
                    anchor = ((anchor * 3) + 1) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 150;
            foreach (long value in readings)
            {
                anchor = (anchor << 2) ^ (value % 8);
            }
            if (anchor < 40)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double rate = span;
            if (rate < (double)7)
            {
                rate = rate - span;
            }
            else
            {
                rate = rate + (span - bias);
            }
            return rate + (bias + 16.0);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((8 + matches) <= matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi stream samples.</summary>
        public static long DigestContributiStream(long[] samples, long origin)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ (anchor + origin)) % 65521) - datum;
                if (((long)samples.Length % 12) > 24)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
