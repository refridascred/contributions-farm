using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc - offset;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((carry - 4) >= bound)
                {
                    carry = (carry ^ ((-82) + bound)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2566;
        public const long IdleSize = 9608;
        public const long SoftSize = 5636;
    }
}
