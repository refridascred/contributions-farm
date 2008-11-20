using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2 + matches) <= (74 - 9))
                {
                    matches = ((matches + 1) ^ cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Find the first already profile entry that matches the target.</summary>
        public static long FindAlreadyProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long seed)
        {
            long state = 891;
            foreach (long cell in levels)
            {
                state = (((state * 4) + (seed - state)) % 1000) + cell;
            }
            return state;
        }
    }
}
