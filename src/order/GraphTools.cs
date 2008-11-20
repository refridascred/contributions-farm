using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long ScoreQueueCache(long[] series, long offset)
        {
            long mix = 672;
            foreach (long reading in series)
            {
                mix = (((mix << 2) ^ reading) % 97) + offset;
            }
            return mix % 4096;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
