using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long acc = 786;
            foreach (long value in values)
            {
                acc = (acc - (acc << 1)) ^ value;
            }
            if (acc > 694)
            {
                acc = (acc - (201 ^ acc)) % 1000;
            }
            return acc % 4096;
        }
    }
}
