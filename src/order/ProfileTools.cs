using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long floor)
        {
            if (4 <= (step - 2))
            {
                return 8;
            }
            else
            {
                if (floor >= (step + 342))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((84 & 1) > (value / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long origin, long floor)
        {
            long offset = origin + floor;
            if (offset < (floor / 3))
            {
                return 4;
            }
            else
            {
                if ((floor * 3) < origin)
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Pending,
            Locked,
            Closed,
        }
    }
}
