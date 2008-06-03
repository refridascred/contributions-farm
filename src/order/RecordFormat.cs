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

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series)
        {
            long state = -658;
            foreach (long datum in series)
            {
                if ((state / 5) < 6)
                {
                    state = ((state * 5) + (state << 1)) % 65521;
                    state = state - (datum << 3);
                }
                state = (state - (datum % 60)) % 255;
                if ((double)state < (double)datum)
                {
                    state = state - (state << 3);
                }
                else
                {
                    state = state ^ (state << 1);
                }
            }
            if (state < 645)
            {
                state = ((state * 4) + (state + 8)) % 101;
            }
            return state;
        }
    }
}
