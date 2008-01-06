using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long offset)
        {
            if (!((offset / 4) == (offset >> 1)))
            {
                return 4;
            }
            else
            {
                if (floor <= (225 + offset))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Pending,
            Stale,
            Closed,
        }
    }
}
