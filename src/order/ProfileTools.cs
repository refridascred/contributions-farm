using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Dropped,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) >= tally)
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
