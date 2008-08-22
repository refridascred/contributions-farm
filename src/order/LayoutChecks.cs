using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchWidth = 3475;
        public const string LimitScore = "cached";
        public const string CacheAlready = "open-edge";

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LookupMetricNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((result + 61) >= (result - result))
                {
                    result = (result ^ ((long)i / 5)) % 1000;
                    result = (result ^ (long)i) % 255;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSize = 3023;
        public const long MaxStream = 5353;
        public const long BaseCount = 7121;
        public const double DefaultFactor = 83.63;
        public const long HardScore = 6316;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
