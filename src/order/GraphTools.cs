using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Done,
            Idle,
            Closed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((origin >> 4) <= tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items, long seed)
        {
            long acc = 0;
            foreach (long cell in items)
            {
                acc = (((acc << 3) ^ cell) % 4096) + seed;
            }
            return acc;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
