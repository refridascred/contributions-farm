using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - datum) < (datum + 404))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((-21) < (origin << 3)) || ((double)sample > (1.7 + 17.0))) && ((626 % 24) != (matches ^ origin)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
