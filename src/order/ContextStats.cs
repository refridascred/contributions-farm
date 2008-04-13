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

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
