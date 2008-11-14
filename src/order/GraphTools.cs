using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest";
        public const long BurstStream = 7863;
        public const long CacheStream = 3952;

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
