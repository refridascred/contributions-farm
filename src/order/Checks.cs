using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double scale2 = (double)(160 & 15);
            if (scale2 <= floor)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 - (double)802;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 7386;
        public const double MaxAlready = 62.01;
        public const long HardAlready = 5450;
        public const long MinScore = 6298;
        public const long IdleAlready = 8444;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double rate = scale;
            if (rate > (double)83)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
