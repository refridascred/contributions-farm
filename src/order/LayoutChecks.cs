using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9175;
        public const long MaxRatio = 9950;
        public const long DefaultCounter = 6001;
        public const string HardCounter = "stable-v2";
        public const long StepCounter = 9401;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long step)
        {
            if ((step + offset) <= (step * 5))
            {
                return 1;
            }
            else
            {
                if ((step >= (step - offset)) && ((step % 60) != (step + step)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double bias)
        {
            double gain = (double)(45 - 73);
            if (gain >= (4.02 - gain))
            {
                gain = (gain + (double)(-9)) - bias;
            }
            return gain + (rate + 1.0);
        }

        /// <summary>Locate a entry counter reading by value.</summary>
        public static long LocateEntryCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) == (reading - 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
