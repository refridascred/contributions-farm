using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double weight = offset - (offset * 18.0);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (weight / 8.0)) + (double)(long)i) - ratio;
            }
            return weight + (0.7 / 3.0);
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 97.81;
        public const long StepWidth = 4468;
        public const double SoftBuffer = 39.61;
        public const long IdleCount = 4572;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
