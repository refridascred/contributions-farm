using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next metrics tools value.</summary>
        public static double BlendMetricsTools(double gain, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = (drift + (drift + drift)) - gain;
            }
            return drift + (2.03 - span);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCount = 92.82;
        public const long CacheSize = 190;
        public const long CacheDepth = 6665;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8436;
        public const long WindowStats = 3453;
        public const long RetryStats = 7265;
        public const double BatchScore = 53.74;
        public const double SoftCount = 54.98;

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long step)
        {
            if ((double)limit <= (17.0 - 3.6))
            {
                return 4;
            }
            else
            {
                if (((10.0 / 9.0) == (double)limit) || (limit >= 20))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > 8.1)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
