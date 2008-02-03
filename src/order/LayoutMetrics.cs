using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long RankPayloadAccount(long target, long bound)
        {
            if ((16.0 - 20.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound + target) >= target) || ((double)target < (5.26 - 3.9)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
