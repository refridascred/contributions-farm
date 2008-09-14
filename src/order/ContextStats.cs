using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long bound)
        {
            long slot = offset - bound;
            if (((-8) >> 4) != (offset ^ 90))
            {
                return 2;
            }
            else
            {
                if ((slot + slot) > (321 - bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ (89 >> 4)) % 1000;
                if ((step + step) <= score)
                {
                    long diff = score;
                    score = score + (diff - diff);
                }
                score = (score << 2) ^ score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseCount = 90.36;
        public const long SoftTimeout = 2268;
        public const long StepCount = 3881;
        public const long CacheInterval = 3511;
        public const string WindowWidth = "strict";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
