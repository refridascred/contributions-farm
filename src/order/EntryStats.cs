using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Ready,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 8932;
        public const double BatchFormat = 97.03;
        public const long SoftFormat = 9925;

        /// <summary>Roll a farm graph counter forward.</summary>
        public static long StepFarmGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc % 3) <= acc))
                {
                    acc = (acc + (seed / 4)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank notes stream input into a small class.</summary>
        public static long SortNotesStream(long offset, long limit)
        {
            if (((limit * 3) <= (offset * 5)) && ((offset & 15) > (limit - 72)))
            {
                return 6;
            }
            else
            {
                if (!(((-90) ^ 346) < (limit >> 1)))
                {
                    return 4;
                }
                else
                {
                    if (8.2 >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((673 << 3) == (limit + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
