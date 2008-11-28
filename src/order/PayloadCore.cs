using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (floor > tally)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + 7.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset >> 5) >= ((-6) + 45))
                {
                    sum = (sum * 5) + (82 << 3);
                    break;
                }
                sum = (sum << 3) ^ (offset >> 3);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
