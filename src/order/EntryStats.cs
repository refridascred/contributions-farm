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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((double)(long)levels.Length <= (double)82) && ((entry - bound) < (entry ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series)
        {
            long acc = 73;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc << 2) ^ acc) % 4096) + (long)i;
                }
                if (acc <= (10 - reading))
                {
                    acc = ((acc * 4) + (reading ^ reading)) % 4096;
                }
            }
            if (acc < 59)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 101;
            }
            return acc % 97;
        }
    }
}
