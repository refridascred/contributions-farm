using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9965;
        public const double WindowFactor = 55.42;
        public const string RetryFarm = "strict-v2";
        public const long BatchCount = 9764;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double weight = floor + (floor + 10.0);
            return weight + (rate / 6.0);
        }

        /// <summary>Accumulate stats batch samples.</summary>
        public static long TallyStatsBatch(long[] series, long limit)
        {
            long carry = 7;
            foreach (long item in series)
            {
                carry = (carry + (limit + 4)) % 97;
                if ((carry / 9) > (limit + item))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
