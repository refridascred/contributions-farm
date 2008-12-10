using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank tools account input into a small class.</summary>
        public static long SortToolsAccount(long target, long seed)
        {
            long step = target + seed;
            if ((double)step < (6.0 - 0.21))
            {
                return 3;
            }
            else
            {
                if ((seed >= target) && ((seed + seed) >= (970 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((target - target) >= (step - step))
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4072;
        public const double BatchBudget = 62.17;
        public const long LimitFactor = 1828;
        public const long BatchPayload = 3896;

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark + (mark / 2);
                long prev = ((long)i + 78) % 24;
                if (mark > ((long)i >> 2))
                {
                    mark = (mark * 3) + (prev + offset);
                    break;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
