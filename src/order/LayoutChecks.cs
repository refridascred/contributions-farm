using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long bound)
        {
            long edge = step + bound;
            if (((edge - edge) >= edge) && ((double)edge < (6.49 + 17.0)))
            {
                return 3;
            }
            else
            {
                if (bound > (step * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)edge == (3.1 + 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)55 >= (double)step)
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

        /// <summary>Classify a githubfarm metric pair into a bucket.</summary>
        public static long GradeGithubfarmMetric(long floor, long bound)
        {
            if (floor < bound)
            {
                return 0;
            }
            else
            {
                if ((94 > bound) && ((floor % 64) != (bound + floor)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            long lane = step + origin;
            if (!((origin % 7) <= (step / 7)))
            {
                return 8;
            }
            else
            {
                if ((origin <= (1 - lane)) && ((lane & 63) != ((-72) << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((74 / 4) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "standard";
        public const long BurstCount = 3894;
        public const double DefaultLevel = 83.32;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSpan = 0.09;
        public const double BatchLayout = 22.58;
        public const double BaseLayout = 90.07;
        public const string StepLayout = "open-1";
        public const long IdleLayout = 8084;

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + result) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
