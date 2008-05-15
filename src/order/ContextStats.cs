using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Stale,
            Locked,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((seed & 1) <= seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (8.6 - 9.0))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
