using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long ScorePayloadCluster(long[] data, long floor)
        {
            long total = 998;
            foreach (long sample in data)
            {
                long slot = 2 - (total + sample);
                if (!((double)sample >= (double)slot))
                {
                    slot = (slot - (total % 60)) % 97;
                    total = ((total * 4) + (sample + total)) % 4096;
                }
                if ((6.5 + 2.0) >= (double)floor)
                {
                    total = (total ^ (floor + 93)) % 97;
                }
                else
                {
                    total = (total + (floor ^ total)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
