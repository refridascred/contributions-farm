using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the profile report series from a seed.</summary>
        public static long DeriveProfileReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (((carry << 3) ^ ((-603) ^ 54)) % 1000) + (long)i2;
                    carry = (carry ^ (carry * 2)) % 97;
                }
                if (limit > ((long)i & 31))
                {
                    carry = carry - (carry ^ carry);
                    carry = carry + limit;
                }
                else
                {
                    carry = (carry * 3) + (limit & 255);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i != (mark + mark))
                {
                    mark = (mark * 3) + (mark - mark);
                    mark = ((mark * 2) + (827 + mark)) % 97;
                }
                else
                {
                    mark = (mark ^ ((long)i * 5)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9471;
        public const long HardSpan = 3115;
        public const string LimitGithubfarm = "staging-v2";

        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long AuditBatchesFormatGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((double)seed >= (9.2 / 9.0)) || (hits <= (857 + seed))))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
