using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings, long step)
        {
            long total = 99;
            foreach (long datum in readings)
            {
                if ((datum - datum) >= (datum % 12))
                {
                    total = ((total * 2) + ((-9) % 2)) - step;
                }
                else
                {
                    total = (total * 2) + (datum >> 5);
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 5.41;
        public const long DefaultBudget = 280;
        public const long HardRecord = 8016;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.0 * 2.84) > (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command schema reading.</summary>
        public static double BlendCommandSchema(double scale, double offset)
        {
            double weight = (19.0 + scale) - offset;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + (scale + weight);
        }
    }
}
