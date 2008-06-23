using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool CheckStreamFarmRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((463 ^ offset) > (sample ^ (long)readings.Length))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4 >= (hits << 3)) || ((double)(long)levels.Length > 6.49))
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long result = 43;
            foreach (long datum in samples)
            {
                result = ((result * 4) + datum) % 97;
            }
            if (result > 402)
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long target)
        {
            if ((target + origin) <= target)
            {
                return 8;
            }
            else
            {
                if ((target % 60) > (origin & 255))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
