using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings)
        {
            long carry = 962;
            foreach (long value in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (carry - carry) + (long)i;
                    carry = (carry << 2) ^ 8;
                }
                carry = carry - (value << 3);
                if ((carry + value) < (carry >> 1))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
