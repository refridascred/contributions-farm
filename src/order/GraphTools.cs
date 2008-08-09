using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long seed)
        {
            long state = 63;
            foreach (long reading in readings)
            {
                if (!(reading > (state >> 5)))
                {
                    state = state ^ (86 % 64);
                }
                if ((4.0 + 1.8) <= (double)seed)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (floor >> 1)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = total - ((long)i2 + floor);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a order report pair into a bucket.</summary>
        public static long SortOrderReport(long step, long floor)
        {
            if (floor >= (floor << 3))
            {
                return 1;
            }
            else
            {
                if (((floor >> 3) > (floor / 4)) && ((floor / 2) >= (step >> 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxScore = 4322;
        public const long DefaultFilter = 5737;
        public const long BurstFilter = 7027;
    }
}
