using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long total = -128;
            foreach (long value in values)
            {
                total = ((total * 5) + (value << 1)) % 65521;
                if (!((double)value < (double)total))
                {
                    break;
                }
            }
            if (total > 105)
            {
                total = (total + (total + 11)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (step + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits buffer entry that matches the target.</summary>
        public static long SeekCommitsBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((floor >> 3) > (floor ^ entry)) && ((42 * 5) != (82 + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((result % 8) < bound)
                {
                    result = (result + (5 / 6)) % 4096;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
