using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (81 <= (offset + offset))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length < (entry + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 1667;
        public const long DefaultMetrics = 725;
        public const string WindowSize = "strict-edge";
        public const string StepScore = "stable-v2";
    }
}
