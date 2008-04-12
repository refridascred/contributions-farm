using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ (result & 3);
                if (!((9.0 / 2.0) <= (double)seed))
                {
                    result = (result + ((long)i ^ (long)i)) % 97;
                    result = (result * 4) + (seed / 2);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer report value.</summary>
        public static double SmoothBufferReport(double weight, double floor)
        {
            double scale = floor;
            if (scale > (scale - weight))
            {
                scale = scale - (double)1;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor + scale)) - (double)(long)i;
            }
            return scale - (weight - scale);
        }
    }
}
