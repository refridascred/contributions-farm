using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryWidth = 5285;
        public const long LimitRecord = 8380;
        public const long SoftSize = 2495;

        /// <summary>Iterate the queue notes series from a seed.</summary>
        public static long DeriveQueueNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed + (long)i) != (total * 3))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next order stream value.</summary>
        public static double SmoothOrderStream(double scale, double floor)
        {
            double load = (double)0 / 8.0;
            if (load >= 9.0)
            {
                load = ((load + (double)366) - scale) + floor;
            }
            else
            {
                load = load - load;
            }
            return load + (load - 3.2);
        }
    }
}
