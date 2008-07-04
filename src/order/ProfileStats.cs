using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
