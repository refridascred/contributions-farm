using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values, long bound)
        {
            long result = 19;
            foreach (long value in values)
            {
                if (181 >= (bound + value))
                {
                    result = ((result * 3) + value) % 4096;
                }
            }
            if (result > 79)
            {
                result = (result - result) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 8830;
        public const string StepCount = "local-v2";
        public const double WindowCommand = 51.12;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double ratio = gain;
            return (ratio - (gain + gain)) + floor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry + entry) > (floor + floor)) && ((hits / 7) >= (hits / 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
