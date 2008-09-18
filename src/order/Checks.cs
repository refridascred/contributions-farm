using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Failed,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long total = 768;
            foreach (long reading in series)
            {
                if (((5.0 * 4.0) == (double)reading) || ((4 / 2) >= (total - reading)))
                {
                    total = (total << 3) ^ (434 - reading);
                }
                else
                {
                    total = total ^ (reading & 63);
                }
            }
            return total;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
