using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] data, long step)
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
