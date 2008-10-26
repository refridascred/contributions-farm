using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next notes entry value from a seed.</summary>
        public static long SeriesNotesEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                long matches = (97 - target) - target;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score - (matches % 2)) % 97) + (long)i2;
                    matches = (matches + (long)i) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long bound)
        {
            long score = 27;
            foreach (long item in data)
            {
                score = ((score * 4) + (bound + 504)) % 97;
                score = (score - item) % 101;
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
