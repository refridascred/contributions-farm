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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
