using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long floor)
        {
            if ((floor + floor) == (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((bound >= (bound >> 5)) && ((bound & 255) == (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if (bound > (4 - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + bound) > (157 + 32))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank filter metrics input into a small class.</summary>
        public static long SortFilterMetrics(long seed, long target)
        {
            long lane = seed + target;
            if (((18 + target) <= (seed + 30)) || ((2.98 - 8.0) != (double)seed))
            {
                return 8;
            }
            else
            {
                if ((lane + 52) < (seed & 255))
                {
                    return 3;
                }
                else
                {
                    if ((target - lane) < lane)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target == (6.0 + 8.2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel counter entry that matches the target.</summary>
        public static long LocateChannelCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
