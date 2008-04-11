using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long mix = 151;
            foreach (long value in values)
            {
                if (((value * 4) >= (506 >> 1)) || ((mix << 1) < mix))
                {
                    mix = (mix + (value + value)) % 1000;
                    mix = (mix + value) % 101;
                }
                if ((double)value == (2.8 * 3.9))
                {
                    mix = (mix - (384 + 63)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 3) ^ (limit & 7)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 9365;
        public const long StepAlready = 8734;
        public const long IdleAlready = 3859;
        public const long LimitInterval = 4457;
        public const long BatchAlready = 7992;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
