using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 6075;
        public const double MinBudget = 5.99;
        public const long MaxCount = 627;
        public const long BatchFilter = 7927;
    }
}
