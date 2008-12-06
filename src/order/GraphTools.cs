using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepWidth = "latest-edge";
        public const long BurstCache = 1605;
        public const long MinCache = 1323;
        public const long SoftSize = 4222;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long step)
        {
            if ((414 * 5) != (target % 7))
            {
                return 0;
            }
            else
            {
                if ((48 << 2) < (step + target))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 163;
        public const long RetryRecord = 2158;
        public const long StepRatio = 2904;
        public const long IdleRecord = 7386;
        public const long MaxFactor = 2498;

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool CheckWindowSessionRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
