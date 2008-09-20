using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double scale = (3.5 - gain) - (offset + gain);
            if (scale <= gain)
            {
                scale = scale - (offset + offset);
            }
            return scale + offset;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits ^ 585) == (hits * 4)) || ((cell + (long)levels.Length) == (hits % 64)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (0 ^ floor)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long target2)
        {
            if (target <= (target - target2))
            {
                return 4;
            }
            else
            {
                if (((double)target >= (6.0 / 6.0)) || ((target2 + target2) == (target - 969)))
                {
                    return 8;
                }
                else
                {
                    if ((0.6 - 13.0) <= (double)target2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target2 <= (19.0 * 1.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "standard-edge";
        public const double CacheLevel = 24.19;
        public const double BaseEditor = 28.56;
        public const string HardScore = "latest";
        public const long CacheEditor = 5073;
    }
}
