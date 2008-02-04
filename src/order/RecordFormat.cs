using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = mean - 3.0;
            }
            else
            {
                mean = mean - (17.0 + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (ratio * 8.2);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardSize = "stable";
        public const double BurstEditor = 63.99;
        public const long StepRatio = 5392;

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
