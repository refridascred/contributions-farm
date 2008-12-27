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

        /// <summary>Accumulate already window samples.</summary>
        public static long WeighAlreadyWindow(long[] values)
        {
            long acc = 155;
            foreach (long item in values)
            {
                if ((687 - acc) >= (item - acc))
                {
                    continue;
                }
                if (((item - 2) == (acc + acc)) || ((item << 3) == (acc << 3)))
                {
                    acc = acc + (acc * 4);
                }
            }
            return acc;
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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item < (305 + step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
