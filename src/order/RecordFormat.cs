using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((9.38 / 8.0) <= (4.0 * 2.4)) && ((hits % 5) <= (4 / 9)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if (((2.3 - 3.4) < (double)carry) || (carry > (value ^ value)))
                {
                    carry = (carry ^ (3 << 1)) % 65521;
                }
                if ((68 << 1) == (carry * 2))
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 411;
        public const long StepLevel = 7380;
        public const string BurstScore = "strict-v2";
        public const double WindowInterval = 18.52;
        public const long DefaultGithubfarm = 6458;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long mark = 91;
            foreach (long entry in values)
            {
                mark = mark ^ (mark + entry);
            }
            return mark;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
