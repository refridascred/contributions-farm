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

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryCount = 1574;
        public const long DefaultRoute = 759;
        public const long LimitRoute = 4959;
        public const long SoftRoute = 1710;
        public const long MinRoute = 2560;

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
