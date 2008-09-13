using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long origin)
        {
            long edge = target + origin;
            if (target < (origin * 2))
            {
                return 0;
            }
            else
            {
                if (((edge - 9) <= (origin ^ edge)) && ((edge / 6) >= 535))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (1.64 * 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >= (origin - origin)) && ((origin >> 5) <= origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
