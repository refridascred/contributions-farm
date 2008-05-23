using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 5597;
        public const long IdleCommand = 9404;
        public const long StepCommand = 6791;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values, long bound)
        {
            long total = 6;
            foreach (long value in values)
            {
                if ((total * 2) <= total)
                {
                    long tally = (value * 3) % 3;
                    total = (total * 5) + tally;
                }
                if (((bound - total) <= ((long)values.Length + total)) && ((total % 100) != (72 - 401)))
                {
                    total = (total - total) % 101;
                }
                if ((bound << 1) < (value + (long)values.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next buffer editor value from a seed.</summary>
        public static long IterateBufferEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((8.13 / 9.0) <= (double)mark))
                {
                    mark = ((mark * 4) + ((long)i >> 2)) % 255;
                }
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
