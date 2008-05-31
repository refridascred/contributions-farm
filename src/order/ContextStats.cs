using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long offset)
        {
            long result = 400;
            foreach (long reading in levels)
            {
                if (!(377 <= (reading + 93)))
                {
                    result = (result * 4) + (reading - result);
                    result = ((result * 5) + 343) % 255;
                }
                if (result >= (offset ^ offset))
                {
                    result = (result ^ 537) % 101;
                }
                else
                {
                    result = (result ^ (offset - 911)) % 65521;
                }
            }
            if (result < (-77))
            {
                result = (result << 2) ^ offset;
            }
            return result;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + ((long)i & 7)) % 4096;
                sum = (sum + (sum % 3)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Locked,
            Stale,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
