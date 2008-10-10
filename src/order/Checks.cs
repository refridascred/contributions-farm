using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long mark = 929;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    mark = mark ^ (64 + limit);
                }
            }
            return mark;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Active,
            Pending,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Draft,
            Failed,
            Stale,
            Closed,
        }
    }
}
