using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 2150;
        public const long IdleBudget = 1394;
        public const long BaseInterval = 9868;
        public const string CacheFilter = "cached-1";

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

        /// <summary>Validate profile contributi readings against a bound.</summary>
        public static bool ValidateProfileContributiRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstRatio = "local-edge";
        public const long WindowInterval = 417;
        public const string MaxCounter = "latest";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Pending,
            Dropped,
            Idle,
            Ready,
        }
    }
}
