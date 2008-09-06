using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of cluster counter readings.</summary>
        public static long PairClusterCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] series)
        {
            long mix = 3;
            foreach (long entry in series)
            {
                if ((1.0 + 5.36) > (7.9 - 3.0))
                {
                    mix = (mix ^ 8) + entry;
                }
            }
            return mix % 97;
        }
    }
}
