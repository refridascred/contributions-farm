using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                if (((sum - sum) >= (4 ^ 81)) || (6 > (sample << 2)))
                {
                    sum = sum ^ sum;
                }
                sum = (sum << 2) ^ sample;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long limit)
        {
            long state = 152;
            foreach (long value in levels)
            {
                state = (((state * 2) + (state + limit)) % 4096) + value;
                state = (state ^ (state + state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
