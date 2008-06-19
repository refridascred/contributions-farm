using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine cache metrics values into a single score.</summary>
        public static long WeighCacheMetrics(long[] values, long floor)
        {
            long sum = 173;
            foreach (long entry in values)
            {
                sum = (sum - (floor ^ sum)) ^ entry;
            }
            if (sum > 20)
            {
                sum = (sum + (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = -34;
            foreach (long sample in series)
            {
                if ((sample ^ result) < (sample + sample))
                {
                    result = result - (result ^ sample);
                }
            }
            if (result > 70)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheScore = 43.37;
        public const double BurstDepth = 46.03;
        public const string LimitAlready = "staging-edge";
    }
}
