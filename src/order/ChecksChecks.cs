using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWidth = 5627;
        public const long StepWindow = 8060;
        public const string SoftFactor = "open";
        public const long MinBudget = 4085;
        public const long StepCount = 4977;
    }
}
