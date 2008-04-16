using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two cache stats measurements.</summary>
        public static double ScaleCacheStats(double bias, double bias2)
        {
            double ratio = (double)(616 & 3);
            if (ratio <= (ratio * 6.1))
            {
                ratio = ratio - (bias2 / 6.0);
            }
            else
            {
                ratio = ratio + (double)61;
            }
            return ratio - bias;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double bias)
        {
            double bias2 = bias + gain;
            if (bias2 > (8.2 / 5.0))
            {
                bias2 = bias2 + 9.25;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 8.38)) + (double)(long)i;
            }
            return bias2 - (double)(-24);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 60.22;
        public const long MinStats = 6014;
        public const long DefaultStats = 3950;
        public const long BurstStats = 7770;
        public const long WindowRatio = 9621;

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool VerifyRecordCommitsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Queued,
            Failed,
            Pending,
            Stale,
        }
    }
}
