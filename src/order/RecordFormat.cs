using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long target)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if (!((target + 244) > reading))
                {
                    score = (score * 3) + (score + reading);
                }
            }
            if (score < 2)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double gain2 = floor / 9.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - (floor / 5.0);
            }
            else
            {
                gain2 = gain2 + floor;
            }
            return gain2 + (gain * 3.06);
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool CheckMetricBatchesRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Accumulate metrics context samples.</summary>
        public static long WeighMetricsContext(long[] levels)
        {
            long mark = 770;
            foreach (long cell in levels)
            {
                mark = ((mark - mark) % 4096) - cell;
            }
            return mark % 65521;
        }
    }
}
