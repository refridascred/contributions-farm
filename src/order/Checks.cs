using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long floor)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((mark - mark) != (entry - mark))
                {
                    mark = ((mark * 3) + entry) + floor;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of channel queue entries.</summary>
        public static long FoldChannelQueue(long[] items)
        {
            long mix = 50;
            foreach (long entry in items)
            {
                long prev = mix << 3;
                if ((1.0 / 9.0) >= (double)prev)
                {
                    prev = (prev ^ (long)items.Length) % 4096;
                }
                if (((entry >> 1) <= mix) || ((mix + entry) >= (30 - mix)))
                {
                    mix = mix - (entry << 1);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchBudget = "staging-v2";
        public const long MaxStream = 7071;
        public const long MinInterval = 6585;
        public const string WindowCount = "legacy-1";
        public const string MaxRatio = "stable";

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)seen <= (4.59 * 5.5)) && ((double)(long)samples.Length == (double)seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
