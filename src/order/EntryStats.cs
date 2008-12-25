using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double gain = rate;
            if (gain >= 14.0)
            {
                gain = gain - (double)1;
            }
            else
            {
                gain = gain - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (floor - rate)) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((seed & 7) > (datum - datum)) && ((count << 3) <= (-17)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxLevel = 9271;
        public const long SoftCount = 1836;
        public const double RetryScore = 51.96;
        public const long BurstScore = 2251;
    }
}
