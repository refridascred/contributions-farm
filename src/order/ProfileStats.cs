using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command token readings against a rule.</summary>
        public static long TallyCommandTokenOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < (8.88 / 9.0))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Validate farm metrics readings against a bound.</summary>
        public static bool CheckFarmMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long sum = 86;
            foreach (long cell in data)
            {
                if ((sum * 2) >= (cell >> 2))
                {
                    sum = (sum ^ (long)data.Length) % 1000;
                    sum = (sum - (cell * 5)) % 101;
                }
                if (((-33) + cell) < (783 - 5))
                {
                    sum = (sum ^ (sum & 63)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            if (sum < 70)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
