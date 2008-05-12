using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine notes command values into a single score.</summary>
        public static long TallyNotesCommand(long[] items, long limit)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                if (!(limit <= acc))
                {
                    acc = (acc ^ (acc / 9)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc - cell)) % 1000;
                }
            }
            if (acc < 45)
            {
                acc = acc + limit;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict-edge";
        public const long DefaultSpan = 8758;
        public const string BatchSession = "legacy-edge";
    }
}
