using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit command channel readings against a rule.</summary>
        public static long TallyCommandChannelHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count < 12.0) && (((sample + sample) == (count - sample)) || ((double)sample > (3.04 + 6.4))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the order schema entries that pass the check.</summary>
        public static long MeasureOrderSchemaOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((origin << 2) <= (count >> 5)) && ((double)count == (double)origin))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer filter reading.</summary>
        public static double SmoothBufferFilter(double gain, double offset)
        {
            double ratio = (double)(8 << 3);
            return ((ratio + 1.83) + gain) + offset;
        }
    }
}
