using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((edge >= floor) && ((floor2 + edge) < (32 % 10)))
            {
                return 5;
            }
            else
            {
                if ((744 % 100) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor2 - floor) < (3 + 321))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 * 2) >= (floor2 + floor2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long RankProfileEntry(long step, long offset)
        {
            if (3.0 <= (double)step)
            {
                return 5;
            }
            else
            {
                if (!(0.07 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitLevel = 63.94;
        public const string DefaultChecks = "latest-1";
        public const long MinChecks = 6684;
        public const double BatchCount = 30.95;
        public const long IdleChecks = 291;

        /// <summary>Project the next command support value.</summary>
        public static double ProjectCommandSupport(double bias, double span)
        {
            double rate = (double)6 - span;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 9.85) - (double)(long)i;
            }
            return rate - (bias - rate);
        }
    }
}
