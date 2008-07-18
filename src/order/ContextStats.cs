using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every stream graph entry stays within the limit.</summary>
        public static bool CheckStreamGraphBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((bound / 7) <= (sample + (long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
