using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardSize = "staging-edge";
        public const long IdleFactor = 7038;
        public const string RetryInterval = "staging-edge";

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                mix = ((mix * 4) + (mix + sample)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Scale a metrics record figure with a bias.</summary>
        public static double AdjustMetricsRecord(double scale, double span)
        {
            double rate = span;
            if (rate >= (rate / 5.0))
            {
                rate = (rate - rate) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate + 3.0;
        }
    }
}
