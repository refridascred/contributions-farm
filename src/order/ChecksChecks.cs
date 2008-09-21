using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(29 <= reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
