using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 60.23;
        public const long WindowBudget = 7935;
        public const long SoftContext = 3847;
        public const long BaseFactor = 2636;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics channel value against two limits.</summary>
        public static long GradeMetricsChannel(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((-1) >= (next & 31))
            {
                return 7;
            }
            else
            {
                if ((3.89 - 0.7) >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (!((1.87 - 9.1) >= (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
