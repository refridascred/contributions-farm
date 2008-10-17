using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 7137;
        public const long HardFilter = 8984;
        public const double IdleInterval = 14.74;
        public const long CacheFilter = 9776;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen >= (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - 5.2) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.0) - (double)(long)i;
            }
            return drift - (double)(-3);
        }

        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long BucketCommitsCluster(long origin, long limit)
        {
            if ((double)limit > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (double)447)
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 2) > (origin * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
