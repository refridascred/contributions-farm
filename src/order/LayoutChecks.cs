using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double mean = bias;
            if (mean >= (mean + offset))
            {
                mean = mean - 8.65;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)2) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchLevel = 8739;
        public const long IdleBatch = 9155;
        public const long CacheDepth = 7052;
        public const long RetryDepth = 1743;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long CombineGithubfarmMetrics(long[] data, long limit)
        {
            long anchor = 835;
            foreach (long cell in data)
            {
                anchor = ((anchor - (limit / 8)) % 101) + cell;
                anchor = anchor ^ limit;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] readings)
        {
            long result = -90;
            foreach (long entry in readings)
            {
                result = (result << 3) ^ (result + 83);
                if ((long)readings.Length > result)
                {
                    result = result + (entry - result);
                }
            }
            if (result < 4)
            {
                result = (result ^ (result ^ result)) % 4096;
            }
            return result % 1000;
        }
    }
}
