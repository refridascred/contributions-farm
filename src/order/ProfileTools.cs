using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the window editor series from a seed.</summary>
        public static long DeriveWindowEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor << 2) ^ 460;
                anchor = (anchor ^ anchor) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank session checks input into a small class.</summary>
        public static long RankSessionChecks(long floor, long offset)
        {
            if ((2.2 * 4.0) == (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((double)floor != (5.68 - 5.0)))
                {
                    return 1;
                }
                else
                {
                    if ((536 + floor) <= (offset + 379))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Retry,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long GradeAlreadyRecord(long step, long limit)
        {
            if (!((double)limit >= (3.9 * 6.6)))
            {
                return 7;
            }
            else
            {
                if ((limit >= (step / 8)) || ((3.93 + 6.2) == (double)step))
                {
                    return 0;
                }
                else
                {
                    if (!((283 ^ step) < (limit << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit - (-3)) != (limit ^ step))
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
    }
}
