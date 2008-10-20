using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (seen + 7))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool CheckClusterNotesBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
