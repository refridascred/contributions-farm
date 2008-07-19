using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next contributi layout value from a seed.</summary>
        public static long RollContributiLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + limit) % 4096;
                if ((double)(long)i >= (double)7)
                {
                    state = (state ^ (limit + state)) % 101;
                }
                else
                {
                    state = (state * 3) + (state & 255);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "standard-edge";
        public const long BurstInterval = 7747;
        public const long BaseGraph = 3358;
        public const string CacheRatio = "cached-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long total = 91;
            foreach (long reading in samples)
            {
                total = ((total << 2) ^ reading) % 4096;
            }
            if (total > 0)
            {
                total = (total * 3) + 88;
            }
            return total;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.46 * 6.12))
                {
                    acc = (acc ^ (entry * 2)) % 4096;
                }
            }
            if (acc > 64)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Validate cluster checks readings against a bound.</summary>
        public static bool CheckClusterChecksLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
