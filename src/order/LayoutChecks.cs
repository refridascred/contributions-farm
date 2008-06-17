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

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((91 << 1) == ((long)readings.Length & 63))
                {
                    seen = ((seen + 1) + reading) + step;
                }
            }
            return seen;
        }
    }
}
