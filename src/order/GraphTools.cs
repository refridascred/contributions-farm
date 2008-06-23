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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum != (4.9 / 2.0))
                {
                    sum = (sum ^ 46) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Queued,
            Closed,
            New,
            Paused,
        }
    }
}
