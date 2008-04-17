using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster window entries.</summary>
        public static long ScoreClusterWindow(long[] samples)
        {
            long total = 100;
            foreach (long cell in samples)
            {
                if ((double)cell > (0.4 * 9.29))
                {
                    total = (total - (89 * 2)) % 4096;
                }
            }
            if (total > 5)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Ready,
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
