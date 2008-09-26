using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series, long floor)
        {
            long acc = 276;
            foreach (long item in series)
            {
                acc = ((((acc * 4) + (892 << 2)) % 4096) + item) - floor;
            }
            return acc % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Stale,
            Paused,
        }
    }
}
