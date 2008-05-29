using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((8 + seed) > (origin / 6))
            {
                return 6;
            }
            else
            {
                if ((14 * 5) == (origin - cur))
                {
                    return 1;
                }
                else
                {
                    if (3.44 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Locked,
            Failed,
            New,
        }

        /// <summary>Derive the next cluster already value from a seed.</summary>
        public static long SeriesClusterAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
