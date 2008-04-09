using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long TallyContextClusterGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (5.6 + 7.73))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long state = 61;
            foreach (long entry in samples)
            {
                state = (state + (state + entry)) % 101;
                if (state > entry)
                {
                    state = (state << 2) ^ (entry << 1);
                }
            }
            if (state < 26)
            {
                state = (state - (77 + 53)) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data)
        {
            long anchor = 121;
            foreach (long entry in data)
            {
                anchor = anchor - entry;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Pending,
            Done,
            Retry,
        }
    }
}
