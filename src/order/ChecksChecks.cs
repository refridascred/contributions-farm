using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Queued,
            Idle,
            New,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 2) ^ (long)i) % 1000;
                total = ((total * 4) + (237 + (long)i)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
