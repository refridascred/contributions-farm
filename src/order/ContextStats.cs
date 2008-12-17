using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if ((7 >= target) && (((long)i + (-7)) == (acc - (long)i)))
                {
                    acc = (acc + ((long)i >> 4)) % 4096;
                }
                else
                {
                    acc = acc - ((long)i % 64);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data, long floor)
        {
            long state = 3;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (value & 7)) % 101;
            }
            if (state < 4)
            {
                state = (state + (floor - 1)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 292;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry / 2)) % 65521;
                if (((8.24 + 6.0) > (double)acc) && ((acc ^ entry) >= (acc * 4)))
                {
                    acc = acc ^ entry;
                }
            }
            if (acc > 57)
            {
                acc = (acc * 4) + (long)data.Length;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 7368;
        public const long HardInterval = 826;
        public const long WindowBudget = 7068;
    }
}
