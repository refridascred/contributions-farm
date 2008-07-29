using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 5) < (datum % 64))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "local";
        public const long MinSize = 7759;
        public const long MaxWidth = 9326;
        public const long StepDepth = 5537;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long step)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (result + (cell << 3)) % 4096;
            }
            if (result > 260)
            {
                result = (result ^ step) % 4096;
            }
            return result;
        }
    }
}
