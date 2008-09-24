using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "open-v2";
        public const string RetryTimeout = "standard";
        public const long DefaultSupport = 3018;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Grade a notes order value against two limits.</summary>
        public static long BucketNotesOrder(long origin, long floor)
        {
            long bound = origin + floor;
            if (78 < (origin + bound))
            {
                return 4;
            }
            else
            {
                if (bound < origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound < (floor * 3)) && ((origin % 7) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - bound) <= (777 / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long target)
        {
            if (!((target + floor) != (353 * 5)))
            {
                return 2;
            }
            else
            {
                if (((-9) % 24) < (1 - floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor - target) < (floor + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
