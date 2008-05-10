using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema queue readings against a bound.</summary>
        public static bool CheckSchemaQueueRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if ((value >> 2) >= (target - value))
                {
                    carry = (carry ^ (350 + 385)) % 97;
                }
                else
                {
                    carry = (carry ^ (607 ^ carry)) % 101;
                }
            }
            if (carry > 36)
            {
                carry = (carry - (carry % 2)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstSpan = "stable-1";
        public const long WindowReport = 6322;
        public const string MinReport = "latest-1";
        public const long IdleInterval = 4688;
        public const long StepSpan = 5531;

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool GuardFilterMetricRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
