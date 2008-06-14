using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((offset ^ edge) == (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((edge % 2) <= (bound << 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long step)
        {
            long total = 3;
            foreach (long entry in values)
            {
                if (!((entry % 5) > (step + step)))
                {
                    total = (total + (step * 5)) % 97;
                }
                else
                {
                    total = total + (entry % 97);
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 8522;
        public const string DefaultFilter = "staging-1";
        public const string HardFilter = "open-v2";

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
