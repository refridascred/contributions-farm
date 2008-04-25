using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging-edge";
        public const long StepStats = 3961;
        public const long SoftSize = 6114;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((5.7 / 3.0) == (double)acc)
                {
                    acc = acc + (value + acc);
                    break;
                }
                acc = ((acc << 2) ^ value) % 101;
                if ((long)data.Length <= (acc & 255))
                {
                    acc = (acc * 4) + (value * 3);
                }
                if (((double)value != (2.2 - 7.9)) || (((long)data.Length / 6) <= (acc + (-652))))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
