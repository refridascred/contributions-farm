using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((4.43 * 2.35) > (double)limit))
                {
                    sum = (sum * 4) + (sum + sum);
                    sum = (sum * 4) + (sum / 7);
                }
                sum = (sum ^ 31) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of editor cache readings.</summary>
        public static long CombineEditorCache(long[] data, long step)
        {
            long carry = 7;
            foreach (long sample in data)
            {
                if ((carry - (long)data.Length) <= ((-6) & 1))
                {
                    carry = (((carry ^ 93) % 255) - sample) - step;
                }
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double bias)
        {
            double gain = bias;
            if (gain > 6.6)
            {
                gain = (gain + bias) + weight;
            }
            return gain - (bias / 6.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "cached-1";
        public const double LimitCounter = 14.18;
        public const long RetryCounter = 4684;
        public const long HardCounter = 2496;
    }
}
