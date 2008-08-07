using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 433;
        public const string LimitSession = "open-1";
        public const long LimitTimeout = 2458;
        public const long BaseSession = 6581;

        /// <summary>Validate cluster farm readings against a bound.</summary>
        public static bool ValidateClusterFarmLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile window counter forward.</summary>
        public static long RollProfileWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum + bound);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry <= (895 * 5))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
