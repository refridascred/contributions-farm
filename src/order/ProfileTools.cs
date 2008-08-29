using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long IterateToolsContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum * 3) + (sum & 127);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 62.6;
        public const double DefaultContributi = 60.44;
        public const double BurstContributi = 55.01;
        public const long CacheSize = 8496;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.1 * 8.7) <= (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
