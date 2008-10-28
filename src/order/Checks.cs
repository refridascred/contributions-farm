using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many record already samples are out of range.</summary>
        public static long TallyRecordAlreadyOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)offset <= 0.5)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double load = 3.5 / 8.0;
            if (load <= (load - floor))
            {
                load = (load + floor) + gain;
            }
            return load - (load / 7.0);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stream route entry stays within the limit.</summary>
        public static bool VerifyStreamRouteLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context token value from a seed.</summary>
        public static long RollContextToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor - (origin & 31);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
