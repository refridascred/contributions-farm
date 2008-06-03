using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (tally - tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
