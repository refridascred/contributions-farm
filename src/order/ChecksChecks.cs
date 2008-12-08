using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long MeasureFarmStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + item) > item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
