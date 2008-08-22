using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((step / 6) != (step ^ entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats cluster readings.</summary>
        public static long WeighStatsCluster(long[] readings)
        {
            long anchor = 935;
            foreach (long value in readings)
            {
                anchor = anchor - value;
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor * 2);
            }
            return anchor % 97;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Synced,
            Done,
            Active,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSize = 3023;
        public const long MaxStream = 5353;
        public const long BaseCount = 7121;
        public const double DefaultFactor = 83.63;
        public const long HardScore = 6316;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
