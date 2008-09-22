using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long state = 9;
            foreach (long cell in items)
            {
                state = (state + (origin % 3)) + cell;
            }
            return state % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 67.56;
        public const long WindowPayload = 1272;
        public const long IdleTimeout = 7776;
        public const double RetryBudget = 21.66;
        public const string IdleBudget = "primary-v2";

        /// <summary>Accumulate farm filter samples.</summary>
        public static long CombineFarmFilter(long[] items, long step)
        {
            long total = -7;
            foreach (long datum in items)
            {
                if ((datum & 255) < (datum << 3))
                {
                    total = (total + (total + step)) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples)
        {
            long state = -225;
            foreach (long entry in samples)
            {
                state = (state + (entry << 2)) % 97;
            }
            return state;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (origin <= (long)i)
                {
                    mark = (mark * 5) + origin;
                }
                mark = ((mark * 4) + origin) % 1000;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark - ((long)i * 5)) % 97) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
