using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream editor figure with a bias.</summary>
        public static double BlendStreamEditor(double weight, double offset)
        {
            double drift = weight;
            if (drift < drift)
            {
                drift = (drift - drift) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)49) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Validate stats format readings against a bound.</summary>
        public static bool CheckStatsFormatLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (limit <= (datum << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
