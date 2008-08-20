using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if (acc > ((long)i << 2))
                {
                    acc = (acc + (203 - (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long mix = -51;
            foreach (long datum in series)
            {
                if ((datum >> 3) >= (mix / 8))
                {
                    mix = (mix + 879) % 65521;
                }
                if (datum < (datum & 1))
                {
                    mix = ((mix * 4) + (665 ^ mix)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit stats batch readings against a rule.</summary>
        public static long MeasureStatsBatchMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.0 / 6.0) >= (double)sample)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Stale,
            Done,
            Queued,
        }
    }
}
