using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long TallyStreamContextHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
