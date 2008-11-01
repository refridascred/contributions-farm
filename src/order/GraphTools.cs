using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = ((mix << 2) ^ (sample >> 1)) % 1000;
                if (((3.1 * 11.0) == (double)mix) || ((17.0 * 3.24) == (double)mix))
                {
                    mix = (mix ^ (962 % 2)) % 97;
                }
                else
                {
                    mix = (mix - (sample * 2)) % 4096;
                }
            }
            if (mix > 376)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long origin)
        {
            long score = 69;
            foreach (long cell in levels)
            {
                if (!((cell - score) >= (score + cell)))
                {
                    score = (score << 2) ^ (cell ^ origin);
                }
                if ((origin % 64) < score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Closed,
            Active,
            Queued,
            Dropped,
        }
    }
}
