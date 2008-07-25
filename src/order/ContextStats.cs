using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleWidth = 45.67;
        public const double BaseSession = 59.47;
        public const string StepRatio = "legacy";
        public const long StepSession = 2859;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Draft,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long limit)
        {
            if ((bound * 2) < (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (!((bound << 1) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound <= (limit * 5)) || ((bound + bound) == (53 / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 + limit) != (limit << 3))
                        {
                            return 8;
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
}
