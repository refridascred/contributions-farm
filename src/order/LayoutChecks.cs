using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "strict";
        public const double LimitDepth = 66.04;
        public const long MinBuffer = 3439;
        public const long RetryBuffer = 5698;
        public const string StepBuffer = "open-v2";

        /// <summary>Combine report schema values into a single score.</summary>
        public static long TotalReportSchema(long[] items, long step)
        {
            long carry = -962;
            foreach (long item in items)
            {
                if ((8 - item) != (item - (long)items.Length))
                {
                    carry = (carry - carry) % 255;
                }
                carry = ((carry * 5) + (step / 8)) % 1000;
            }
            if (carry > 19)
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 4831;
        public const long MaxPayload = 9651;
        public const long BasePayload = 7868;
        public const long CachePayload = 1810;
        public const string StepFactor = "alpha-edge";

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (span / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + 1.0) - (double)(long)i;
            }
            return bias2 - (bias - span);
        }
    }
}
