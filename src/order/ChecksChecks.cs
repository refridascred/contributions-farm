using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long seed)
        {
            long result = 564;
            foreach (long entry in series)
            {
                result = (((result ^ (result + (long)series.Length)) % 255) + entry) + seed;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 2512;
        public const long BurstSpan = 7173;
        public const long DefaultQueue = 6523;
        public const double HardSpan = 86.84;
    }
}
