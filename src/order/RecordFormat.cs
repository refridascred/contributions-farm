using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long offset)
        {
            if ((7.95 + 6.2) < (double)target)
            {
                return 0;
            }
            else
            {
                if ((offset / 8) < offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a metric editor counter forward.</summary>
        public static long StepMetricEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit - carry) >= (carry % 5))
                {
                    long next = carry;
                    carry = (carry << 2) ^ next;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
