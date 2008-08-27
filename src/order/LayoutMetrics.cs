using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "stable-edge";
        public const long SoftFormat = 4813;
        public const long MaxFormat = 9682;

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long limit)
        {
            long carry = 25;
            foreach (long sample in data)
            {
                if (((limit % 60) >= sample) || ((double)sample < (double)(long)data.Length))
                {
                    carry = ((carry * 3) + carry) % 65521;
                }
                else
                {
                    carry = (carry * 4) + (carry + 1);
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
