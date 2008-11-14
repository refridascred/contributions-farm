using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] items, long bound)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if (!((57 % 2) >= mark))
                {
                    mark = ((((mark * 2) + mark) % 255) ^ value) + bound;
                }
                mark = ((mark * 3) + mark) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowDepth = 3393;
        public const double MinWidth = 88.59;
        public const double IdleAccount = 12.21;
        public const long StepAccount = 4986;
        public const long LimitAccount = 9255;

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 86.94;
        public const string BaseFarm = "alpha";
        public const long MinCount = 3581;
        public const long BaseDepth = 836;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
