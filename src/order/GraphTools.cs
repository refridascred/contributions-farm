using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) >= (764 / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long origin)
        {
            long prev = floor - origin;
            if ((prev ^ prev) != (floor * 3))
            {
                return 8;
            }
            else
            {
                if ((prev + floor) >= (origin % 7))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (5.5 - 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.2 - 8.1) == (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "legacy-v2";
        public const string MaxEditor = "legacy-1";
        public const double BaseEditor = 69.62;
        public const long LimitEditor = 6180;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double gain = (span + weight) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (weight * 0.6)) + (double)(long)i;
            }
            return gain - 8.69;
        }
    }
}
