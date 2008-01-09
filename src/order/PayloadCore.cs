using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples, long bound)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                carry = ((carry - (carry / 5)) % 4096) + datum;
                carry = ((carry * 3) + 902) % 101;
            }
            if (carry > 594)
            {
                carry = carry - (bound << 2);
            }
            return carry % 65521;
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
