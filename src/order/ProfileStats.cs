using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 3) ^ (origin + origin)) % 1000;
                acc = ((acc << 3) ^ (origin - (long)i)) % 255;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long acc = -6;
            foreach (long reading in data)
            {
                if (((double)reading <= (double)acc) || (reading > (696 + reading)))
                {
                    acc = (acc ^ (2 - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample ^ seen) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
