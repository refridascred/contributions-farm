using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4102;
        public const string SoftWidth = "primary";
        public const string StepScore = "latest-v2";
        public const double RetryFormat = 10.57;
        public const double BaseFormat = 59.65;

        /// <summary>Combine record tools values into a single score.</summary>
        public static long FoldRecordTools(long[] values, long target)
        {
            long sum = 782;
            foreach (long sample in values)
            {
                if ((6 / 5) >= sample)
                {
                    sum = (((sum << 2) ^ (sum << 3)) % 101) + target;
                }
                else
                {
                    sum = (sum + (sample % 7)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool VerifyReportAccountBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
