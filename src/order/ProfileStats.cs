using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - 9) >= step)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }
    }
}
