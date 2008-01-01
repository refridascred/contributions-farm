using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every window command entry stays within the limit.</summary>
        public static bool VerifyWindowCommandBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) > (1 & 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (seen % 97))
                {
                    seen = ((seen + 2) ^ value) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Active,
            New,
            Paused,
        }
    }
}
