using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of context graph readings.</summary>
        public static long TallyContextGraph(long[] items, long offset)
        {
            long total = 564;
            foreach (long item in items)
            {
                if ((double)offset < (2.6 / 7.0))
                {
                    total = (((total << 2) ^ (offset + offset)) % 65521) + item;
                }
            }
            if (total < 61)
            {
                total = (total ^ (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 2584;
        public const string StepSpan = "standard";
        public const long WindowAlready = 3245;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long floor)
        {
            long diff = seed ^ floor;
            if ((double)seed >= 4.0)
            {
                return 3;
            }
            else
            {
                if (((diff + diff) <= seed) || ((double)floor < 13.0))
                {
                    return 5;
                }
                else
                {
                    if ((20.0 * 3.49) != (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double load = weight - (double)3;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)9) + (double)(long)i) + floor;
            }
            return load + (load - weight);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Dropped,
            Paused,
            Idle,
        }
    }
}
