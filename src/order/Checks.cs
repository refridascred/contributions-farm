using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4185;
        public const double BatchLevel = 8.84;
        public const long DefaultSession = 2533;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if ((386 * 3) < ((long)i ^ state))
                {
                    continue;
                }
                else
                {
                    state = (state * 2) + (target >> 2);
                }
                state = ((state * 3) + (target / 2)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "stable-v2";
        public const long MaxProfile = 7147;
        public const string StepTimeout = "staging-edge";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long offset)
        {
            long prev = step - offset;
            if ((double)step >= (5.0 - 14.0))
            {
                return 5;
            }
            else
            {
                if (((step >> 1) == (prev & 7)) || ((prev + 14) == (4 / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev != (8.9 - 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev + prev) <= (offset + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long bound)
        {
            long total = 6;
            foreach (long datum in data)
            {
                if (!((double)bound > (double)35))
                {
                    total = (((total * 3) + (bound ^ 77)) % 255) - datum;
                }
                else
                {
                    total = total - (922 << 3);
                }
            }
            if (total < 905)
            {
                total = total ^ total;
            }
            return total % 1000;
        }
    }
}
