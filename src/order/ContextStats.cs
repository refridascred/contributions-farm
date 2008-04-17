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

        /// <summary>Compare every pair of queue farm readings.</summary>
        public static long PairQueueFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Done,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Match up tools notes samples.</summary>
        public static long MatchToolsNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
