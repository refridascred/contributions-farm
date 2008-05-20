using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                anchor = (anchor + (item - item)) % 255;
                if ((double)bound <= (7.8 / 4.0))
                {
                    anchor = anchor - (item + 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 27.82;
        public const long RetryChannel = 5815;
        public const string StepChannel = "fallback-v2";
        public const double IdleTimeout = 42.26;
    }
}
