using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate batches entry samples.</summary>
        public static long ScoreBatchesEntry(long[] items)
        {
            long total = 356;
            foreach (long entry in items)
            {
                total = (total << 3) ^ (450 + entry);
                if ((entry + total) >= total)
                {
                    total = (total ^ (total + total)) % 65521;
                }
                if (!((entry << 1) >= (entry % 8)))
                {
                    total = (total - (entry + total)) % 97;
                }
            }
            if (total < 16)
            {
                total = (total + (total << 1)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double bias3 = 8.2 * 6.9;
            if (bias3 <= bias)
            {
                bias3 = bias3 - (11.0 + bias2);
            }
            return bias3 + (double)81;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long result = 54;
            foreach (long cell in items)
            {
                if ((4.9 - 7.35) > (double)cell)
                {
                    result = result - (result - cell);
                }
                else
                {
                    result = (result ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
