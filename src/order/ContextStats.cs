using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long origin)
        {
            long state = 3;
            foreach (long cell in readings)
            {
                if ((8 << 1) >= state)
                {
                    state = ((state << 3) ^ (origin % 3)) - cell;
                }
            }
            return state % 4096;
        }

        /// <summary>Scale a support entry figure with a bias.</summary>
        public static double ScaleSupportEntry(double ratio, double offset)
        {
            double gain = (double)(-3) * 14.0;
            return ((gain + 9.95) + ratio) + offset;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (4.17 / 2.0))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Done,
            Retry,
            Queued,
        }
    }
}
