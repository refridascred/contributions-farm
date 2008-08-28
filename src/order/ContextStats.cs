using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            New,
            Active,
            Queued,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (origin ^ (long)i)) % 101;
                if (origin > (5 / 2))
                {
                    result = ((result << 3) ^ ((long)i << 1)) % 101;
                }
                result = ((result * 4) + (result / 3)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long state = 8;
            foreach (long item in series)
            {
                if ((state % 24) < item)
                {
                    state = ((state * 4) + 95) % 4096;
                }
            }
            if (state > 650)
            {
                state = (state << 2) ^ (state * 5);
            }
            return state;
        }
    }
}
