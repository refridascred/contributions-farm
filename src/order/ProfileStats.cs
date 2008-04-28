using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a channel checks value against two limits.</summary>
        public static long GradeChannelChecks(long origin, long seed)
        {
            if ((6.96 / 7.0) == (double)seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed > 5.7)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank githubfarm queue input into a small class.</summary>
        public static long SortGithubfarmQueue(long limit, long floor)
        {
            if ((limit ^ floor) > (976 >> 1))
            {
                return 0;
            }
            else
            {
                if ((limit + floor) < (floor / 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 2) == (1 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-314) << 1) > (268 + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - limit) != (6 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit + 16) <= (limit & 255))
                {
                    return 6;
                }
                else
                {
                    if (((origin / 7) < (origin << 3)) && ((726 + limit) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (960 <= (limit % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "standard-1";
        public const double DefaultContributi = 40.69;
        public const long HardContributi = 5355;
        public const long BatchContributi = 3591;
    }
}
