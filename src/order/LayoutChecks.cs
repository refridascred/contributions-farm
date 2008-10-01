using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Validate session graph readings against a bound.</summary>
        public static bool CheckSessionGraphBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
