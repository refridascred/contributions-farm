using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchSize = 40.66;
        public const string IdleChecks = "stable-edge";
        public const long RetryChecks = 5098;
        public const long StepChecks = 1777;
        public const long LimitRatio = 6148;

        /// <summary>Grade a format report value against two limits.</summary>
        public static long BucketFormatReport(long bound, long step)
        {
            if (((-971) - bound) != (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.54 - 5.96))
                {
                    return 1;
                }
                else
                {
                    if ((bound > (step + step)) && (bound < (bound ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long DigestSupportStats(long[] series, long floor)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = ((total + (5 & 255)) - item) + floor;
            }
            return total % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                long gap = (77 - (-46)) + offset;
                if ((carry - gap) != (carry ^ (long)i))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
