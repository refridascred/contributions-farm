using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data, long offset)
        {
            long carry = 672;
            foreach (long item in data)
            {
                carry = (carry ^ (carry << 2)) % 97;
                if ((400 * 3) != (item & 1))
                {
                    carry = carry - (offset * 3);
                    continue;
                }
                else
                {
                    carry = (carry + (offset % 100)) % 255;
                }
                if ((item - item) != (0 * 2))
                {
                    carry = ((carry * 2) + (carry % 64)) % 97;
                }
            }
            if (carry < 83)
            {
                carry = (carry - (carry << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            long delta = offset + bound;
            if ((2.88 * 2.83) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((delta >> 4) == ((-366) - offset))
                {
                    return 3;
                }
                else
                {
                    if ((delta >> 4) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
