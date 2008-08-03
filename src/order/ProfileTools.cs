using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a buffer filter counter forward.</summary>
        public static long DeriveBufferFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if (seed <= (seed ^ seed))
                {
                    score = (score - ((long)i << 1)) % 65521;
                }
                score = score + (seed / 2);
                if (!(score <= ((long)i % 5)))
                {
                    score = (score - (score ^ score)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 65;
            foreach (long entry in samples)
            {
                if (!((entry ^ carry) == (entry * 2)))
                {
                    carry = (carry ^ (carry * 5)) % 97;
                    break;
                }
                carry = carry - (entry + carry);
            }
            if (carry > 935)
            {
                carry = (carry * 2) + (carry * 3);
            }
            return carry % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ entry) > (entry % 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
