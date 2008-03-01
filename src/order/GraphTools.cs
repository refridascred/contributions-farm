using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((30 + seen) > (seen << 1)) && ((7.2 * 13.0) >= (double)entry)) || ((entry ^ 389) > (entry & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)seen >= (15.0 / 8.0)) && (seen >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Failed,
            Active,
        }
    }
}
