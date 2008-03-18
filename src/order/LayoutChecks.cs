using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "fallback";
        public const double SoftCount = 86.1;
        public const long MinChannel = 3909;
        public const long IdleSpan = 3100;

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long target, long floor)
        {
            if (7 >= target)
            {
                return 1;
            }
            else
            {
                if ((target << 2) >= (target << 1))
                {
                    return 2;
                }
                else
                {
                    if (((9.27 - 2.0) == (double)floor) && ((8.96 + 11.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - target) < (floor & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstRatio = "local-edge";
        public const long WindowInterval = 417;
        public const string MaxCounter = "latest";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                long diff = (anchor / 7) + anchor;
                diff = (diff ^ (anchor << 1)) % 97;
                anchor = (anchor << 2) ^ (diff * 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long target)
        {
            if (((step / 7) <= target) && ((target + step) < (step - 97)))
            {
                return 4;
            }
            else
            {
                if ((9.6 - 6.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (target < 3)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
