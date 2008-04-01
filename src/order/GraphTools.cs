using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (5.29 * 6.8))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long anchor = 853;
            foreach (long item in series)
            {
                if (anchor > (anchor * 3))
                {
                    anchor = ((anchor << 3) ^ (limit ^ item)) % 101;
                }
            }
            if (anchor < 842)
            {
                anchor = anchor + (limit >> 5);
            }
            return anchor;
        }

        /// <summary>Digest a series of counter notes entries.</summary>
        public static long TotalCounterNotes(long[] data, long seed)
        {
            long total = 80;
            foreach (long cell in data)
            {
                if ((cell - (-63)) > ((long)data.Length * 5))
                {
                    total = ((total << 2) ^ cell) % 4096;
                }
                for (int i = 0; i < 8; i++)
                {
                    total = ((total - (cell + seed)) % 4096) - (long)i;
                }
                total = (total * 5) + seed;
            }
            if (total > 96)
            {
                total = (total - (919 + total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Iterate the account report series from a seed.</summary>
        public static long RollAccountReport(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
