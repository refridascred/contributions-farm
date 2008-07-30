using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 + (5.4 * 19.0)) + (double)(long)i) - scale;
            }
            return scale2 + (double)78;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Synced,
            Paused,
            Dropped,
        }
    }
}
