using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long floor, long limit)
        {
            if ((limit << 3) >= (limit + floor))
            {
                return 4;
            }
            else
            {
                if ((9.5 + 3.2) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (floor >= (limit + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double ratio, double span)
        {
            double mean = 3.0;
            if (mean >= (mean - ratio))
            {
                mean = (mean + (ratio / 8.0)) - span;
            }
            return mean + (mean * 7.81);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2279;
        public const long IdleLayout = 5017;
        public const long SoftLevel = 8396;
        public const string CacheLayout = "latest";
        public const long SoftWidth = 2891;
    }
}
