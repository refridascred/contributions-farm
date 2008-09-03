using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((floor2 & 7) > (floor + slot))
            {
                return 1;
            }
            else
            {
                if (!((14.0 - 8.6) == (double)slot))
                {
                    return 6;
                }
                else
                {
                    if (((slot % 100) < floor2) || ((floor & 1) > (slot - floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 > (slot % 60)) && ((floor2 % 60) == (slot + slot)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long seed)
        {
            long slot = target + seed;
            if ((double)slot > (double)target)
            {
                return 5;
            }
            else
            {
                if (((seed + target) > (slot - seed)) && ((slot - 312) >= (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (seed > slot)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed > 0)
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
    }
}
