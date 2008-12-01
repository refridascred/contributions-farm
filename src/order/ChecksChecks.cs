using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if ((sample + sample) != ((-71) - 91))
                {
                    state = (state + (sample / 4)) % 255;
                }
                state = ((state << 3) ^ (sample + state)) % 255;
            }
            return state;
        }
    }
}
