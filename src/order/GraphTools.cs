using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ (origin ^ origin)) % 101;
                if (((8.0 * 16.0) < (double)total) && ((origin + (long)i) > (origin & 255)))
                {
                    total = (total ^ (7 & 63)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) <= (value + 151))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data)
        {
            long result = 64;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (((result * 3) + (result * 4)) % 97) - (long)i2;
                }
                if ((result / 3) != ((long)data.Length * 3))
                {
                    result = ((result << 3) ^ (3 - value)) % 4096;
                }
                else
                {
                    result = (result - (value * 3)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
