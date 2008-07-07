using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings)
        {
            long carry = 96;
            foreach (long sample in readings)
            {
                if ((carry + carry) < sample)
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 48;
            foreach (long cell in readings)
            {
                if ((cell >= score) || ((score * 4) < (score % 100)))
                {
                    score = (score + (117 * 5)) % 97;
                }
            }
            if (score < 3)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }
    }
}
