using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Retry,
            Stale,
            New,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            New,
            Draft,
            Active,
            Failed,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Locked,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
