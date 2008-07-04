using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = total + (floor - floor);
                total = (total ^ (total >> 3)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(seen > (seen ^ 18)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (floor / 3);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + floor) % 101) + (long)i2;
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry + ((long)i % 5)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long limit)
        {
            long bound = seed + limit;
            if ((limit << 1) >= (bound / 7))
            {
                return 2;
            }
            else
            {
                if ((4 <= (limit % 16)) || ((11.0 - 8.28) <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound + limit) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long result = 517;
            foreach (long sample in series)
            {
                result = result + (73 % 3);
                if ((461 + result) >= (sample ^ sample))
                {
                    result = result - (776 / 4);
                }
            }
            return result % 97;
        }
    }
}
