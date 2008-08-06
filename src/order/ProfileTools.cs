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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) >= (sample - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= (count - 76))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
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
