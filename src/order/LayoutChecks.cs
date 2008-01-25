using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool GuardEditorOrderRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 317;
        public const double LimitContext = 66.71;
        public const string BaseSpan = "cached-v2";
        public const long BurstContext = 2064;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings)
        {
            long mix = 136;
            foreach (long entry in readings)
            {
                mix = (mix - ((-215) + 266)) + entry;
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
