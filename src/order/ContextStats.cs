using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 1544;
        public const long DefaultNotes = 8175;
        public const long WindowRatio = 3537;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long step)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                if ((reading + 89) == (step + (-5)))
                {
                    mix = (mix ^ ((-1) << 1)) % 4096;
                }
                if (!((double)mix > (7.83 + 7.0)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
