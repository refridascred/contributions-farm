using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((6.4 - 20.0) >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (offset - weight2))
            {
                weight2 = weight2 - (double)922;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
