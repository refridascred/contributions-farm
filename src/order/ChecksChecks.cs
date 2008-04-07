using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long target)
        {
            long next = step - target;
            if (!(((-99) / 9) != (target / 5)))
            {
                return 8;
            }
            else
            {
                if (((target - 8) >= target) && (step <= (target << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target > (3.8 * 1.56))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - target) < (next & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Paused,
            Closed,
        }
    }
}
