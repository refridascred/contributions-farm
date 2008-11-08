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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
