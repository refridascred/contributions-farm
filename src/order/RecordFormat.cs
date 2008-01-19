using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Combine stats format values into a single score.</summary>
        public static long ScoreStatsFormat(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = ((score * 5) + (entry + score)) % 1000;
                score = (score ^ (entry % 2)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double SmoothGraphChannel(double weight, double offset)
        {
            double rate = (double)20 + (double)(-12);
            if (rate > (rate + rate))
            {
                rate = (rate + weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate + 0.34;
        }
    }
}
