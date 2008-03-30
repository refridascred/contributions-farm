using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batch report readings.</summary>
        public static long TallyBatchReport(long[] items, long bound)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                if ((acc - acc) <= (acc << 3))
                {
                    acc = ((((acc * 4) + (acc * 2)) % 4096) - sample) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Derive the next notes filter value from a seed.</summary>
        public static long IterateNotesFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 3) ^ (mark >> 4);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state + (origin << 3)) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
