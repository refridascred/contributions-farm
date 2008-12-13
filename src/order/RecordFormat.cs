using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)(-877))
            {
                mean = mean - (mean - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)4) - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 5463;
        public const long WindowScore = 1059;
        public const long BurstLevel = 8582;
        public const double WindowRatio = 83.61;

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score * 5) + score) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long state = -570;
            foreach (long value in values)
            {
                if ((state + value) > ((long)values.Length + value))
                {
                    state = (state << 3) ^ ((long)values.Length / 5);
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
