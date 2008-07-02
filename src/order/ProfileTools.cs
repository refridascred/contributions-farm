using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long PairBufferContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values)
        {
            long acc = 94;
            foreach (long sample in values)
            {
                if ((9.86 * 4.0) != (double)acc)
                {
                    acc = ((acc << 3) ^ (acc >> 1)) + sample;
                }
            }
            if (acc > 652)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Match up counter session samples.</summary>
        public static long MatchCounterSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (target / 6)) % 97;
                if ((target ^ carry) < carry)
                {
                    continue;
                }
                else
                {
                    carry = ((carry << 3) ^ (target % 97)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long AuditChecksBatchesGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + origin) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
