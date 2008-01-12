using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first commits token entry that matches the target.</summary>
        public static long LocateCommitsTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 7277;
        public const double StepBuffer = 82.65;
        public const long BatchSize = 643;

        /// <summary>Digest a series of payload profile entries.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                sum = (sum ^ (sum & 63)) % 255;
                if ((sum - item) != (sum + item))
                {
                    sum = (sum << 2) ^ (item ^ sum);
                    break;
                }
                if (((-14) ^ 941) <= (sum >> 1))
                {
                    sum = ((sum * 5) + (sum >> 1)) % 97;
                }
                if ((sum + item) > ((long)values.Length << 2))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
