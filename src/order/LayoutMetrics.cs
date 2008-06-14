using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark / 3)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Retry,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Draft,
            Paused,
            Idle,
        }
    }
}
