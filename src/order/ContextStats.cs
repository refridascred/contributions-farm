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

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((long)i == (57 % 2)))
                {
                    score = ((score << 3) ^ (score << 3)) % 255;
                }
                score = (score ^ (target - target)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long CombineBatchesSchema(long[] items, long limit)
        {
            long total = 10;
            foreach (long datum in items)
            {
                total = (((total << 2) ^ 76) - datum) + limit;
            }
            return total;
        }
    }
}
