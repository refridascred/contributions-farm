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

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
