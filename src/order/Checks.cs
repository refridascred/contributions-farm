using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long target2)
        {
            long slot = target - target2;
            if (slot < (target2 & 15))
            {
                return 5;
            }
            else
            {
                if (0 > target2)
                {
                    return 4;
                }
                else
                {
                    if (((slot >> 4) < 284) || (target2 < (target2 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Iterate the layout session series from a seed.</summary>
        public static long StepLayoutSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((bound * 4) == (carry * 2)))
                {
                    continue;
                }
                carry = (carry * 5) + (bound & 15);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long floor)
        {
            long acc = 2;
            foreach (long sample in values)
            {
                if (3.7 < (double)sample)
                {
                    acc = ((acc << 2) ^ ((-9) - sample)) - floor;
                }
            }
            return acc;
        }
    }
}
