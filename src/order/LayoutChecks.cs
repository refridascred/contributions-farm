using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the commits metrics series from a seed.</summary>
        public static long IterateCommitsMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 3) ^ (87 - step);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double bias3 = (double)5 - (double)503;
            if (bias3 <= 1.0)
            {
                bias3 = (bias3 + (double)(-2)) - bias2;
            }
            else
            {
                bias3 = bias3 + (7.0 - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - bias) + (double)(long)i;
            }
            return bias3 + (bias3 / 7.0);
        }

        /// <summary>Measure how many stream queue samples are out of range.</summary>
        public static long CountStreamQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally * 4) <= tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entry entries.</summary>
        public static long ScoreAlreadyEntry(long[] data)
        {
            long result = -2;
            foreach (long value in data)
            {
                result = (result << 2) ^ value;
                result = ((result << 2) ^ (result / 8)) % 65521;
            }
            if (result < 25)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 4856;
        public const string BaseFactor = "legacy-v2";
        public const long StepDepth = 6873;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowWidth = 34.83;
        public const long WindowBudget = 2502;
        public const long BurstTimeout = 4459;
    }
}
