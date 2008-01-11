using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if (!((8.4 * 2.3) < (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit * 3) < (limit % 10))
                {
                    return 5;
                }
                else
                {
                    if (floor > (floor - 200))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit < (7.3 * 13.0)) || (((-4) - 121) >= (floor ^ limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double mean = (double)(9 + 3);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (bias * 1.01)) + (double)(long)i) + scale;
            }
            return mean - (bias * 9.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const string DefaultRecord = "legacy";
        public const long BurstBudget = 489;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
