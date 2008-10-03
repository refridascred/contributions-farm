using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = 585;
            foreach (long cell in data)
            {
                if ((double)cell < 0.25)
                {
                    acc = ((acc * 2) + (acc + acc)) % 101;
                }
                else
                {
                    acc = (acc + (304 + 69)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Synced,
            Queued,
            Active,
            Draft,
        }
    }
}
