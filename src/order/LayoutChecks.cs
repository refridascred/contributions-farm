using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] items)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = ((sum - (1 & 127)) % 4096) ^ entry;
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long gap = (bound / 4) % 3;
                if (8.0 > (double)(long)i)
                {
                    mix = ((mix * 4) + (bound * 3)) % 1000;
                    gap = (gap + (573 - (long)i)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (gap & 31)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = -89;
            foreach (long cell in samples)
            {
                if (((mix % 24) >= (cell << 2)) && ((double)cell == (8.0 - 9.4)))
                {
                    mix = (mix - cell) % 101;
                }
            }
            if (mix < 93)
            {
                mix = mix ^ (mix * 2);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long limit)
        {
            long mix = 9;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (mix / 7)) + cell) + limit;
            }
            return mix % 4096;
        }

        /// <summary>Count the filter graph entries that pass the check.</summary>
        public static long CountFilterGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally < (tally + tally))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
