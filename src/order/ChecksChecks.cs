using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools farm pair into a bucket.</summary>
        public static long BucketToolsFarm(long seed, long offset)
        {
            long cur = seed - offset;
            if ((899 ^ cur) > (offset + offset))
            {
                return 3;
            }
            else
            {
                if (cur > (cur * 5))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 2) == (seed - cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double weight = (double)(75 - 6);
            if (weight > (1.6 + 5.55))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.94) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (4.98 * 5.0))
            {
                weight2 = weight2 - (span * 14.0);
            }
            return weight2 + (double)94;
        }
    }
}
