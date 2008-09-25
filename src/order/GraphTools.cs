using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (reading - anchor)) % 255;
                anchor = (anchor ^ (674 << 1)) % 1000;
                if (((reading & 31) >= (anchor * 3)) && ((4.2 / 8.0) != (double)offset))
                {
                    anchor = anchor - (anchor % 3);
                }
                if ((offset << 2) > offset)
                {
                    break;
                }
            }
            if (anchor < 290)
            {
                anchor = (anchor * 3) + offset;
            }
            return anchor;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long limit)
        {
            long total = 489;
            foreach (long entry in samples)
            {
                if ((limit * 3) > limit)
                {
                    total = ((total << 3) ^ (limit ^ limit)) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Done,
            Locked,
            Dropped,
            Draft,
        }
    }
}
