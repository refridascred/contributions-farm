using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools notes counter forward.</summary>
        public static long RollToolsNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                acc = (acc + (960 + acc)) % 97;
                acc = (acc * 4) + reading;
            }
            return acc;
        }
    }
}
