using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context entry entries.</summary>
        public static long ScoreContextEntry(long[] data, long bound)
        {
            long state = 34;
            foreach (long sample in data)
            {
                state = (((state ^ 5) % 255) - sample) - bound;
            }
            return state % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Rank { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
