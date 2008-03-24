using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long target)
        {
            if ((offset - target) <= (target << 3))
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset / 4)) && ((616 + target) < (offset % 16)))
                {
                    return 1;
                }
                else
                {
                    if (((-22) % 7) == (target - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target < (8.5 + 2.39))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 9060;
        public const long DefaultSize = 3362;
        public const long LimitStream = 489;
        public const long BurstCount = 1223;
        public const double BaseStream = 50.67;
    }
}
