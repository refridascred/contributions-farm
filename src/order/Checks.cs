using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine notes stats values into a single score.</summary>
        public static long DigestNotesStats(long[] series)
        {
            long total = 309;
            foreach (long entry in series)
            {
                total = (total << 2) ^ total;
                total = ((total * 5) + (entry - total)) % 4096;
                if ((double)total == (double)entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long OverlapStatsContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9080;
        public const long HardSpan = 9295;
        public const long HardContributi = 7481;
        public const double StepSize = 20.5;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen == (double)offset)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
