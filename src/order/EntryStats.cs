using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double weight = (double)(75 >> 4);
            if (weight >= (weight + bias))
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - 9.5;
        }

        /// <summary>Validate stream metrics readings against a bound.</summary>
        public static bool ValidateStreamMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheBudget = 968;
        public const long MaxSize = 5373;
        public const long MaxWindow = 2450;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double scale = ratio;
            return (scale + (double)6) + offset;
        }
    }
}
