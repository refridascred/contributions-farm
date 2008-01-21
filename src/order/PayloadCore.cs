using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits - item) > (item << 2))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((total % 24) != (956 >> 2))
                {
                    total = total - (origin ^ origin);
                    continue;
                }
                total = ((total << 3) ^ (origin + total)) % 4096;
                if (!((double)(long)i == (double)origin))
                {
                    total = (total ^ (total % 100)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark ^ offset) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
