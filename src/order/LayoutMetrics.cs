using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a stream report reading by value.</summary>
        public static long SeekStreamReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi graph input into a small class.</summary>
        public static long RankContributiGraph(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((double)57 <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((0 & 7) < (diff % 97))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepSpan = 63.53;
        public const string IdleRatio = "strict-v2";
        public const long BurstRecord = 3760;
    }
}
