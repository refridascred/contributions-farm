using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheSpan = 70.85;
        public const double IdleInterval = 30.24;
        public const long IdleContext = 4429;
        public const double BatchWidth = 95.16;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) == (reading + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
