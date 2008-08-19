using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double bias = floor / 9.0;
            if (bias < (rate * 1.7))
            {
                bias = bias - (double)4;
            }
            return bias - (double)(-60);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total - total)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long seed)
        {
            long acc = 26;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (((acc * 5) + (seed / 5)) % 101) ^ (long)i;
                }
                if (!((8.36 / 4.0) <= (8.6 / 2.0)))
                {
                    acc = (acc - 2) % 101;
                }
                else
                {
                    acc = (acc - (cell & 1)) % 97;
                }
            }
            if (acc > 767)
            {
                acc = (acc * 3) + (acc << 3);
            }
            return acc % 4096;
        }
    }
}
