using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + (long)i) > ((long)i * 2))
                {
                    acc = (acc * 5) + (long)i;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc << 1)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples, long target)
        {
            long total = 790;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length > (double)909)
                {
                    total = ((total * 4) + (total >> 3)) - reading;
                }
            }
            if (total < 50)
            {
                total = (total * 4) + (target - total);
            }
            return total;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
