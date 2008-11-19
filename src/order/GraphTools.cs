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

        /// <summary>Count entry route pairs that satisfy a relation.</summary>
        public static long OverlapEntryRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings)
        {
            long result = 31;
            foreach (long sample in readings)
            {
                if ((result % 16) > result)
                {
                    result = (((result * 2) + (850 * 4)) % 4096) ^ sample;
                }
                if (result < 353)
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = ((result * 5) + 9) % 101;
            }
            return result;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
