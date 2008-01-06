using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate stats buffer readings against a bound.</summary>
        public static bool VerifyStatsBufferBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 18;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor * 3) + (item << 1)) % 101) ^ (long)i;
                    anchor = (anchor - anchor) % 255;
                }
                anchor = ((anchor << 2) ^ (anchor << 1)) % 4096;
                if ((double)item <= (4.92 + 11.0))
                {
                    anchor = (anchor << 2) ^ item;
                }
                else
                {
                    anchor = anchor + (anchor / 2);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (limit + reading)) % 1000;
                if ((limit - anchor) <= limit)
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((datum * 4) <= datum) && (((3.9 - 19.0) > (double)tally) || ((double)tally != (10.0 - 6.2))))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
