using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window support values into a single score.</summary>
        public static long TallyWindowSupport(long[] readings, long limit)
        {
            long sum = 12;
            foreach (long cell in readings)
            {
                if (!((9.92 - 4.3) != (double)sum))
                {
                    sum = ((sum ^ (0 * 5)) + cell) + limit;
                }
                sum = (sum + (11 % 10)) % 4096;
            }
            if (sum < 9)
            {
                sum = sum - (369 ^ sum);
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseSize = "legacy-edge";
        public const long MinChannel = 3515;
        public const double StepChannel = 25.9;
        public const double BatchChannel = 67.82;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long offset)
        {
            long result = 635;
            foreach (long reading in samples)
            {
                if (!(reading >= (179 << 3)))
                {
                    result = (result * 3) + result;
                }
                if ((offset + offset) <= (562 + 7))
                {
                    result = (result - (result << 1)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardRatio = 719;
        public const long DefaultEditor = 8781;
        public const long LimitEditor = 3909;
        public const long HardSpan = 8950;
        public const long BurstEditor = 2700;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            New,
            Idle,
            Active,
            Draft,
        }
    }
}
