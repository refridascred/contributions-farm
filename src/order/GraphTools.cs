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

        /// <summary>Look up the position of a record context sample.</summary>
        public static long LookupRecordContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue buffer counter forward.</summary>
        public static long RollQueueBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
