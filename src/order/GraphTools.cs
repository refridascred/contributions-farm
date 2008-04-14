using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long origin)
        {
            long score = -96;
            foreach (long datum in samples)
            {
                if (!(score < (score - datum)))
                {
                    score = (((score * 3) + (score << 3)) % 65521) - origin;
                }
                if ((double)datum < (1.8 / 3.0))
                {
                    break;
                }
                score = score + (417 >> 3);
            }
            return score % 1000;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
