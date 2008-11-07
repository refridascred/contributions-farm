using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                carry = carry ^ (reading + 6);
                if ((89 + carry) > reading)
                {
                    carry = (carry + (reading * 5)) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry * 2) + (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Locate a notes queue reading by value.</summary>
        public static long SeekNotesQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long seed)
        {
            if ((seed - 42) < (60 ^ target))
            {
                return 3;
            }
            else
            {
                if (1.3 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double drift = (double)(302 * 2);
            if (drift <= (drift + 16.0))
            {
                drift = (drift + (double)6) + bias;
            }
            return drift + (span / 5.0);
        }
    }
}
