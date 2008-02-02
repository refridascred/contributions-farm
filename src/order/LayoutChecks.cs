using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long StepBufferSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin + total) <= (total + 554))
                {
                    total = total ^ origin;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading <= bound) && (((double)bound < (8.0 + 4.0)) || ((781 * 2) < (matches - bound))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long floor)
        {
            long mark = 262;
            foreach (long cell in items)
            {
                if (!((floor + mark) <= (cell * 3)))
                {
                    mark = (mark ^ ((-7) << 1)) % 97;
                }
                else
                {
                    mark = mark - (floor * 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long bound)
        {
            if (!(bound >= (step << 3)))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
