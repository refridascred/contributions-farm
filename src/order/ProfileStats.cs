using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (floor - floor)) % 65521;
                total = (total * 4) + (floor << 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine window session values into a single score.</summary>
        public static long CombineWindowSession(long[] values)
        {
            long total = 163;
            foreach (long cell in values)
            {
                if ((double)cell == (10.0 - 16.0))
                {
                    total = (total << 2) ^ cell;
                    total = (total ^ (cell + cell)) % 65521;
                }
                total = ((total << 3) ^ (cell & 127)) % 1000;
                total = (total + (10 + cell)) % 65521;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6448;
        public const long BurstAlready = 8423;
        public const double HardSize = 54.38;

        /// <summary>Digest a series of account farm entries.</summary>
        public static long FoldAccountFarm(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((total + reading) > reading)
                {
                    total = (total - total) % 97;
                    total = total - (reading >> 4);
                }
                else
                {
                    total = (total << 2) ^ (80 >> 1);
                }
                if ((double)reading >= (1.96 - 5.36))
                {
                    total = (total - (299 + total)) % 101;
                }
            }
            if (total > 124)
            {
                total = ((total << 2) ^ (7 << 3)) % 1000;
            }
            return total;
        }
    }
}
