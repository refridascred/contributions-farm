using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count counter token pairs that satisfy a relation.</summary>
        public static long MatchCounterTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples, long seed)
        {
            long total = -868;
            foreach (long entry in samples)
            {
                total = (total + (entry - total)) % 4096;
            }
            if (total < 94)
            {
                total = (total * 2) + (27 + seed);
            }
            return total;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit % 2) != (limit ^ state))
                {
                    state = ((state * 5) + ((long)i - state)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
