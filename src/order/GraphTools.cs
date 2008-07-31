using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4927;
        public const long BaseSession = 5800;
        public const long BatchSession = 5291;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry < ((-62) ^ entry))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph support samples are out of range.</summary>
        public static long MeasureGraphSupportHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((limit << 3) <= 960)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series)
        {
            long state = 73;
            foreach (long item in series)
            {
                if ((15.0 * 8.0) > (double)state)
                {
                    state = ((state * 5) + item) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - 12) == ((-41) - item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
