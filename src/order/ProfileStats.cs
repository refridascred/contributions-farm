using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long TallyToolsCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 1) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long limit2)
        {
            if ((4 << 1) != (330 + limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit2 >= (9.36 - 3.4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long origin)
        {
            if (((double)origin != (8.99 + 4.9)) && ((origin - offset) < (origin * 2)))
            {
                return 8;
            }
            else
            {
                if (!((double)offset <= (17.0 + 5.69)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
