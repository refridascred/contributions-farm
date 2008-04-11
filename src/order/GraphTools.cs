using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] levels)
        {
            long sum = -87;
            foreach (long datum in levels)
            {
                sum = (sum << 2) ^ (sum + datum);
                sum = ((sum << 3) ^ (datum << 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Locked,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((tally << 3) >= (datum / 7)) || (tally <= (tally + datum))) && !((datum / 6) < 952))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
