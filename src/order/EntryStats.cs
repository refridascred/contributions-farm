using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCount = 381;
        public const double RetryCount = 96.02;
        public const long StepCache = 2531;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (value >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
