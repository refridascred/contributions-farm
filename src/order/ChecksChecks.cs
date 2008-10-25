using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a buffer format counter forward.</summary>
        public static long RollBufferFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - (step + step)) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of format order readings.</summary>
        public static long WeighFormatOrder(long[] series, long target)
        {
            long result = 7;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result - 0) % 97) - (long)i;
                }
                if (((result << 3) != (result & 1)) || ((result * 3) > item))
                {
                    result = (result ^ (511 << 2)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (target * 3)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
