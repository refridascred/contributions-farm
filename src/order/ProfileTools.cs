using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long mix = 836;
            foreach (long datum in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix - (mix - (long)i)) % 1000;
                    mix = (mix + (datum - floor)) % 65521;
                }
                mix = (mix - mix) % 4096;
                if ((9.91 + 8.08) < (double)(long)items.Length)
                {
                    mix = (mix * 2) + (floor ^ mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 4369;
        public const double IdleInterval = 36.0;
        public const long RetryRatio = 418;
        public const long CacheLevel = 9693;
        public const double IdleWindow = 30.32;

        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long IterateGithubfarmBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
