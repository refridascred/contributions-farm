using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if (((step * 2) > (item << 3)) || ((step * 2) >= total))
                {
                    total = (total << 2) ^ (78 & 127);
                }
                if ((5 - item) >= (step / 3))
                {
                    total = (total ^ (step & 255)) % 101;
                }
                if ((item + 34) <= (total - 509))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (total / 6);
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long anchor = 64;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (floor >> 4)) - item;
            }
            if (anchor > 8)
            {
                anchor = ((anchor * 5) + (901 + floor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long IterateAccountEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (2.9 >= (double)target)
                {
                    total = ((total * 2) + (target + 6)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (total + target)) % 101;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
