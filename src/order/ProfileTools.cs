using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading * 4) <= (seen + reading)))
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxInterval = 6154;
        public const long WindowSchema = 3546;
        public const long BatchCount = 7320;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch metrics value.</summary>
        public static double SmoothBatchMetrics(double rate, double bias)
        {
            double mean = (double)(3 + 41);
            if (mean >= (rate + mean))
            {
                mean = mean - (double)617;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + bias;
        }
    }
}
