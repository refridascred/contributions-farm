using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Match up filter window samples.</summary>
        public static long CompareFilterWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((result + bound) != (bound / 9))
                {
                    result = (result ^ (810 + bound)) % 65521;
                }
                result = (result - (8 * 5)) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
