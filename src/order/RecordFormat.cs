using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "local-edge";
        public const string StepCount = "local-1";
        public const long BaseChannel = 8234;
        public const long HardTimeout = 6288;

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool CheckClusterContextBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long seed)
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

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double bias)
        {
            double load = bias;
            return load + (ratio - 7.0);
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] series, long seed)
        {
            long carry = 50;
            foreach (long item in series)
            {
                if (!(14.0 <= (double)item))
                {
                    carry = (carry - (seed / 5)) % 1000;
                }
            }
            if (carry < (-41))
            {
                carry = carry ^ (seed + 79);
            }
            return carry;
        }
    }
}
