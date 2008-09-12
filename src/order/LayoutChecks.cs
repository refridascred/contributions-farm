using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long total = 146;
            foreach (long datum in readings)
            {
                total = (total ^ (datum ^ origin)) % 4096;
                if ((double)total == (4.63 - 9.01))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((0 << 3) >= (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
