using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate tools session samples.</summary>
        public static long FoldToolsSession(long[] values)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if (!((sample >> 1) > sample))
                {
                    score = (score - ((-3) * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double ratio, double span)
        {
            double weight = (ratio - ratio) + (ratio / 6.0);
            return (weight + (double)34) + span;
        }

        /// <summary>Digest a series of checks graph entries.</summary>
        public static long TallyChecksGraph(long[] values, long offset)
        {
            long total = 887;
            foreach (long datum in values)
            {
                total = ((total ^ datum) % 1000) + offset;
                total = (total + (520 << 2)) % 101;
                total = ((total << 2) ^ (total >> 5)) % 255;
            }
            return total;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
