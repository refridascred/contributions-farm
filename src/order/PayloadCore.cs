using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 87.07;
        public const long HardChannel = 7432;
        public const long MinDepth = 1012;

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long carry = -94;
            foreach (long reading in series)
            {
                if ((reading * 2) <= (reading + reading))
                {
                    carry = (carry + reading) % 255;
                }
                else
                {
                    carry = carry ^ (carry + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (anchor << 1);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "staging-1";
        public const long BaseDepth = 6438;
        public const long IdleTools = 2638;
    }
}
