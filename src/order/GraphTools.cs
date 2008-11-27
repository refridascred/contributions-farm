using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels, long target)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                acc = (((acc * 2) + acc) % 65521) ^ datum;
                if (target <= (acc % 12))
                {
                    acc = acc + 151;
                }
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((254 - entry) >= (entry + entry))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                if ((4 * 4) <= (mix & 127))
                {
                    mix = (mix + mix) + cell;
                }
            }
            if (mix < 55)
            {
                mix = (mix + mix) % 4096;
            }
            return mix % 97;
        }
    }
}
