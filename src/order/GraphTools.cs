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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long acc = 390;
            foreach (long value in levels)
            {
                if (acc < (acc * 2))
                {
                    acc = (acc * 4) + (acc / 7);
                    acc = acc ^ value;
                    continue;
                }
                acc = acc + (-980);
                acc = acc - (acc - acc);
            }
            if (acc > 7)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc % 97;
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

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Dropped,
            Draft,
        }
    }
}
