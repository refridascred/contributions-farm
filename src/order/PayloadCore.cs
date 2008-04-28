using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "strict-edge";
        public const double LimitBudget = 55.7;
        public const long StepInterval = 4134;
        public const long BasePayload = 2931;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long target, long target2)
        {
            long step = target + target2;
            if (step >= (-691))
            {
                return 8;
            }
            else
            {
                if (((step + target) == (target * 2)) && ((double)step == (5.5 + 6.75)))
                {
                    return 5;
                }
                else
                {
                    if (2.0 > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((0.7 - 3.5) == (double)offset)
                {
                    sum = (sum * 4) + sum;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
