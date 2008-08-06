using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) < (4 >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a tools farm reading by value.</summary>
        public static long LookupToolsFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin > (9 - (long)i)) && ((long)i >= state))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)hits >= 6.68) && ((datum - 82) == (hits * 5)))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
