using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double mean = (floor / 7.0) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (9.36 + scale)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue report sample.</summary>
        public static long LookupQueueReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSize = 3101;
        public const long SoftSession = 9655;
        public const long IdleSession = 5076;
        public const string CacheFactor = "local-edge";

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if ((17 ^ bound) != (3 & 3))
            {
                return 1;
            }
            else
            {
                if (((step << 1) > bound) || ((double)bound >= 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step <= (bound >> 5)) && (bound <= 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
