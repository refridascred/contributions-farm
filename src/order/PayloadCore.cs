using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long target)
        {
            long sum = 784;
            foreach (long cell in samples)
            {
                if ((cell & 15) >= target)
                {
                    sum = (sum << 3) ^ (target >> 3);
                }
            }
            return sum % 4096;
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
