using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long mix = 4;
            foreach (long cell in data)
            {
                mix = ((mix - (mix * 4)) % 97) + cell;
                mix = (mix - ((-9) + mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series)
        {
            long mix = 26;
            foreach (long value in series)
            {
                if (6.12 <= (double)mix)
                {
                    continue;
                }
                else
                {
                    mix = ((mix * 4) + (mix * 4)) % 97;
                    mix = (mix - (mix << 3)) % 4096;
                }
                if ((value + mix) > (586 - mix))
                {
                    mix = (mix + (mix ^ 620)) % 1000;
                }
                if ((mix + mix) >= mix)
                {
                    mix = (mix - (value / 2)) % 97;
                }
                else
                {
                    mix = (mix * 4) + (value ^ value);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm queue entries.</summary>
        public static long DigestGithubfarmQueue(long[] data)
        {
            long mark = 96;
            foreach (long sample in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark * 3) + sample) % 255) + (long)i;
                }
                if ((mark + mark) <= mark)
                {
                    mark = ((mark << 2) ^ (44 ^ mark)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardRatio = 48.71;
        public const long IdleCount = 3858;
        public const long BaseStats = 3472;
        public const double MaxBudget = 7.54;
        public const long LimitStats = 4630;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
