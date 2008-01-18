using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin2 * 2) < delta)
            {
                return 7;
            }
            else
            {
                if (!((double)delta == (0.97 * 4.3)))
                {
                    return 4;
                }
                else
                {
                    if (origin >= delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "standard-1";
        public const long RetryBuffer = 4153;
        public const long MaxBuffer = 7022;
        public const long BatchBuffer = 8392;
        public const double SoftBuffer = 24.66;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long step)
        {
            if ((limit < (step + step)) && ((step >> 5) < step))
            {
                return 3;
            }
            else
            {
                if (((step * 2) <= step) || ((limit - limit) > 2))
                {
                    return 0;
                }
                else
                {
                    if (((step * 2) != (step & 3)) || ((limit << 3) <= 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - step) <= (step - (-261)))
                        {
                            return 5;
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
