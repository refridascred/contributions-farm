using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum * 2) + (73 + sum)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6505;
        public const long StepDepth = 4669;
        public const long LimitCluster = 9631;
        public const long BaseCluster = 4957;
    }
}
