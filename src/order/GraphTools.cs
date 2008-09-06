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

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double rate = span / 8.0;
            if (rate < (weight + weight))
            {
                rate = rate - (7.0 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 2.2) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
