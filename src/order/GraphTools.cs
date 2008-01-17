using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account context counter forward.</summary>
        public static long StepAccountContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + carry;
                if ((167 * 2) >= target)
                {
                    carry = (carry - (carry - carry)) % 4096;
                }
                if ((carry + carry) == (target * 3))
                {
                    carry = (carry + (target & 63)) % 1000;
                    carry = (carry << 2) ^ (73 + carry);
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (target ^ 327)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 5050;
        public const long HardTimeout = 2813;
        public const string CacheRatio = "legacy-v2";
        public const long DefaultFactor = 1501;
        public const long HardMetrics = 7908;

        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
