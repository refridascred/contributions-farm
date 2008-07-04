using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((63 < (limit / 4)) && ((double)tally == (6.0 / 5.0)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
