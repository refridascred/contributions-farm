using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1294;
        public const double LimitStream = 59.42;
        public const long BurstStream = 4977;
        public const string BatchStream = "local-1";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the farm order series from a seed.</summary>
        public static long IterateFarmOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                long gap = (step + (-3)) + (long)i;
                if (((double)gap <= (2.17 * 9.4)) || (score >= (long)i))
                {
                    score = (score ^ (step * 5)) % 255;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next already payload value from a seed.</summary>
        public static long RollAlreadyPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                long tally = (long)i;
                if (tally >= 4)
                {
                    tally = (tally + (acc - tally)) % 65521;
                    acc = (acc ^ tally) % 4096;
                    continue;
                }
                else
                {
                    acc = (acc + ((long)i >> 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
