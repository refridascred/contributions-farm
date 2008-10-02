using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 746;
            foreach (long reading in items)
            {
                if (7.5 < (double)result)
                {
                    result = (result + (reading - 763)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit support profile readings against a rule.</summary>
        public static long TallySupportProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry - 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
