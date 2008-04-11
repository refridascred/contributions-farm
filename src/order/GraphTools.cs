using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((double)seed2 > (0.12 + 7.1))
            {
                return 8;
            }
            else
            {
                if (seed2 > (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
