using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long floor)
        {
            if ((178 % 2) != ((-870) + bound))
            {
                return 6;
            }
            else
            {
                if (9 > (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double rate = gain;
            if (rate > span)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item + matches) <= (matches - matches)) && ((item % 10) < (matches * 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
