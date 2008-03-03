using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a session entry reading.</summary>
        public static double BlendSessionEntry(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale - bias2;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long step)
        {
            long delta = limit ^ step;
            if ((limit + delta) <= ((-9) - limit))
            {
                return 4;
            }
            else
            {
                if (limit < (limit - 4))
                {
                    return 3;
                }
                else
                {
                    if ((step << 3) < (step + 671))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (222 <= (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 89.1;
        public const double HardCount = 84.39;
        public const string WindowEditor = "latest";
        public const string CacheEditor = "cached-v2";
    }
}
