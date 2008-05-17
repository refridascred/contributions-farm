using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Done,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Project the next format payload value.</summary>
        public static double ScaleFormatPayload(double weight, double offset)
        {
            double mean = weight + (2.8 + 19.0);
            if (mean < offset)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (double)7;
            }
            return mean - (weight * 4.3);
        }

        /// <summary>Compare every pair of contributi cache readings.</summary>
        public static long OverlapContributiCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((floor - (-7)) == (item << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double gain = (double)((-2) & 7);
            if (gain >= 5.0)
            {
                gain = gain + 3.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias / 6.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Queued,
            Stale,
        }
    }
}
