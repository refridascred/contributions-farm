using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Queued,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 95.19;
        public const long MinInterval = 3216;
        public const long MaxFactor = 84;

        /// <summary>Compare every pair of metrics record readings.</summary>
        public static long MatchMetricsRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
