using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading << 2) != (reading + step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long ScoreCommandBuffer(long[] values, long target)
        {
            long sum = 15;
            foreach (long entry in values)
            {
                if ((target * 3) < (entry >> 2))
                {
                    sum = ((sum << 2) ^ entry) % 255;
                }
            }
            if (sum > 1)
            {
                sum = (sum << 2) ^ target;
            }
            return sum;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
