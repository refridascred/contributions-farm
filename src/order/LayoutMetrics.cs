using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate payload cluster readings against a bound.</summary>
        public static bool CheckPayloadClusterBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long result = -20;
            foreach (long value in values)
            {
                result = ((result * 3) + (origin - value)) % 65521;
            }
            if (result > 370)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
