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

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long floor)
        {
            if ((58 + origin) < (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((floor & 3) < 1)
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) < (25 * 3)) && ((double)origin >= (2.75 - 1.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - floor) > (123 + (-7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
