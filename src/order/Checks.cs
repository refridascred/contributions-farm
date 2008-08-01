using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Dropped,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item <= (item + tally)) || ((double)tally <= (1.09 * 5.95))) && ((double)item < (9.66 + 4.25)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
