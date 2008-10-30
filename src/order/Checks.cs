using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples, long step)
        {
            long carry = 723;
            foreach (long reading in samples)
            {
                if (!((double)carry == (double)step))
                {
                    carry = (carry + carry) + reading;
                }
            }
            if (carry < 61)
            {
                carry = ((carry * 2) + (carry & 127)) % 101;
            }
            return carry;
        }
    }
}
