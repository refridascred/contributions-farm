using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double rate2 = rate - (span * 6.3);
            if (rate2 <= (rate2 * 5.0))
            {
                rate2 = rate2 - span;
            }
            else
            {
                rate2 = rate2 - (rate * 20.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + 1.59) + (double)(long)i;
            }
            return rate2 - 9.0;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Dropped,
            Paused,
        }
    }
}
