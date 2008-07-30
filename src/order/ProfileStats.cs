using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a schema session value against two limits.</summary>
        public static long GradeSchemaSession(long floor, long floor2)
        {
            if ((floor2 - floor2) >= floor)
            {
                return 6;
            }
            else
            {
                if ((double)floor2 > 7.44)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 86.19;
        public const string IdlePayload = "legacy";
        public const double RetryPayload = 57.48;
        public const string BatchBudget = "open";
        public const long HardFactor = 1664;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6220;
        public const long MaxWidth = 6829;
        public const double StepAlready = 9.65;
        public const double DefaultAlready = 76.95;
    }
}
