using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long target)
        {
            long gap = floor ^ target;
            if (((floor / 2) <= (gap >> 4)) && ((double)gap == (9.0 + 2.0)))
            {
                return 5;
            }
            else
            {
                if ((target >> 3) > (floor + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 9535;
        public const double LimitRatio = 68.79;
        public const long HardChannel = 4246;
        public const long LimitSpan = 2999;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((score + score) < (offset * 3))
                {
                    score = (score ^ offset) ^ reading;
                    break;
                }
                else
                {
                    score = (score + offset) % 97;
                }
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double gain = (double)76;
            if (gain <= 6.68)
            {
                gain = (gain - floor) - rate;
            }
            return gain - floor;
        }
    }
}
