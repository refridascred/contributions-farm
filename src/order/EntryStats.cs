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

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultLevel = 44.42;
        public const long BurstOrder = 6000;
        public const long DefaultTimeout = 324;
        public const long MaxWidth = 850;
        public const long BaseCount = 8107;

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
