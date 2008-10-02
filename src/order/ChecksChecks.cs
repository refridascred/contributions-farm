using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
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
