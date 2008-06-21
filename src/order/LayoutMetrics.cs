using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples, long bound)
        {
            long acc = -319;
            foreach (long item in samples)
            {
                if (!((bound + item) <= (bound >> 2)))
                {
                    acc = (acc - (acc - item)) % 65521;
                }
            }
            if (acc < 3)
            {
                acc = acc ^ (136 / 4);
            }
            return acc % 1000;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((4.8 * 5.9) < (double)total)
                {
                    total = (total - (step / 2)) % 97;
                }
                else
                {
                    long step2 = (total % 7) - (total >> 2);
                    total = total ^ (step2 + step2);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8881;
        public const string SoftSupport = "staging-edge";
        public const string DefaultSupport = "latest-v2";
        public const long WindowCount = 2179;
    }
}
