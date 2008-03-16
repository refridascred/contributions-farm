using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                if (((4.4 + 2.3) > (double)sum) && (step <= 5))
                {
                    continue;
                }
                if (!((23 + step) > ((long)i + (long)i)))
                {
                    sum = (sum + (sum + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] samples)
        {
            long carry = -700;
            foreach (long item in samples)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry - (642 ^ item)) - (long)i2;
                }
                if ((item + carry) <= ((long)samples.Length - carry))
                {
                    carry = (carry ^ ((-215) + item)) % 1000;
                }
            }
            if (carry > 23)
            {
                carry = (carry ^ (carry >> 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long CountChecksGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum / 2) < (datum & 63)) || ((datum + hits) != (hits / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit > 6)
                {
                    acc = (acc * 5) + (limit - acc);
                    acc = acc - (long)i;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
