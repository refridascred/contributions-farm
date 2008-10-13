using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a counter layout figure with a bias.</summary>
        public static double BlendCounterLayout(double weight, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift + (double)96;
            }
            return drift - (3.26 + weight);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((mix % 7) < (limit - 2))
                {
                    mix = (mix ^ (limit * 4)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
