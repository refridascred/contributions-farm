using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next githubfarm queue value from a seed.</summary>
        public static long DeriveGithubfarmQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i - sum) < (sum & 3)))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (sum % 100)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next batches filter value from a seed.</summary>
        public static long RollBatchesFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed & 63) <= carry)
                {
                    carry = carry + ((long)i + seed);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Stale,
            Dropped,
            Active,
        }
    }
}
