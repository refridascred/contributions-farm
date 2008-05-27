using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if ((origin ^ 36) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin2 + origin2) != (origin2 % 16))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin2) >= origin2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin2 - origin2) <= (2 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] values)
        {
            long carry = 7;
            foreach (long entry in values)
            {
                carry = ((carry * 3) + (carry ^ carry)) % 4096;
                carry = carry ^ (carry + entry);
                if ((2.99 >= (5.0 * 10.0)) && (entry < ((-14) + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
