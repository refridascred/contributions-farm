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

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
