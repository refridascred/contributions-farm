using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels, long target)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                if ((double)target > (double)6)
                {
                    sum = ((sum << 2) ^ (datum - 995)) % 97;
                }
            }
            if (sum < 966)
            {
                sum = (sum << 3) ^ (target / 8);
            }
            return sum;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = total + 983;
                total = ((total << 3) ^ (81 + total)) % 65521;
                total = (total - ((long)i + (long)i)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
