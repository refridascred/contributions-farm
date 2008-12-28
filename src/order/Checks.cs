using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double rate = bias;
            if (rate <= (rate - rate))
            {
                rate = (rate - 3.0) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 3.6) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up record tools samples.</summary>
        public static long MatchRecordToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next format tools value.</summary>
        public static double AdjustFormatTools(double bias, double floor)
        {
            double scale = (double)526 * 2.68;
            if (scale <= scale)
            {
                scale = (scale - (floor * 5.12)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (scale + 1.2);
        }
    }
}
