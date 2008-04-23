using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((8.0 - 7.0) <= (double)carry)
                {
                    carry = (carry + (step - 5)) % 101;
                }
                if ((step & 15) > carry)
                {
                    carry = (carry ^ ((long)i * 3)) % 101;
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a batches tools value against two limits.</summary>
        public static long GradeBatchesTools(long origin, long seed)
        {
            if (!(origin <= (seed - origin)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed > 7.0))
                {
                    return 7;
                }
                else
                {
                    if (!(origin >= (origin - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
