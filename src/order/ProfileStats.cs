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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if ((0 / 2) != (mix / 5))
                {
                    mix = (mix << 3) ^ (mix - mix);
                }
                else
                {
                    mix = mix + (target * 2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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
