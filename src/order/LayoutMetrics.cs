using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Compare every pair of farm githubfarm readings.</summary>
        public static long MatchFarmGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context batches readings.</summary>
        public static long CombineContextBatches(long[] items, long origin)
        {
            long mix = 39;
            foreach (long entry in items)
            {
                if (95 <= (entry << 1))
                {
                    mix = ((mix << 3) ^ (entry - origin)) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}
