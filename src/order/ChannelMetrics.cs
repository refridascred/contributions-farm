using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((64 + (-21)) <= (3 ^ offset)) || ((double)sum >= 6.06))
                {
                    sum = (sum << 3) ^ (offset << 1);
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const double BatchCounter = 27.34;
        public const long LimitCounter = 2114;

        /// <summary>Digest a series of editor record entries.</summary>
        public static long ScoreEditorRecord(long[] items, long floor)
        {
            long carry = 99;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 4) + ((long)items.Length + 14)) % 255) - (long)i;
                }
                if ((double)552 == (double)entry)
                {
                    carry = (carry - (95 + 45)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + floor;
                }
            }
            return carry;
        }
    }
}
