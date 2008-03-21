using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 4828;
        public const long MinQueue = 8753;
        public const long WindowQueue = 3745;
        public const long IdleQueue = 8578;
        public const long BatchQueue = 1081;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + result) % 65521;
                if (((origin ^ (-2)) != (53 << 2)) && ((8.1 + 6.2) <= (double)result))
                {
                    break;
                }
                else
                {
                    result = (result << 2) ^ (9 >> 3);
                    result = (result + (origin + 818)) % 97;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
