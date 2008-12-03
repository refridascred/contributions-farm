using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double weight = floor;
            if (weight < weight)
            {
                weight = weight + (weight + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long floor)
        {
            long state = -512;
            foreach (long value in data)
            {
                state = (((state << 3) ^ (70 + floor)) % 255) + value;
            }
            if (state > 376)
            {
                state = state + state;
            }
            return state % 1000;
        }

        /// <summary>Roll a support cluster counter forward.</summary>
        public static long RollSupportCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (!(((double)(long)i < (double)result) && (245 < (3 + result))))
                {
                    result = result ^ result;
                }
                if ((target ^ (long)i) < (target - (long)i))
                {
                    result = (result + target) % 65521;
                }
                else
                {
                    result = result ^ (target + result);
                    result = (result << 3) ^ target;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
