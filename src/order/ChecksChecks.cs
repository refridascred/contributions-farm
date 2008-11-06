using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count farm metrics pairs that satisfy a relation.</summary>
        public static long MatchFarmMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
