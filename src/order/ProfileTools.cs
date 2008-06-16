using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 1;
            foreach (long value in series)
            {
                carry = (carry - value) % 97;
                if (((value / 9) != ((long)series.Length & 127)) || (carry > (carry & 3)))
                {
                    carry = ((carry * 2) + ((-8) << 1)) % 101;
                }
                else
                {
                    carry = ((carry * 5) + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = sum + (seed - seed);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 18.42;
        public const string BasePayload = "alpha-1";
        public const long BaseFactor = 7746;
        public const long MaxDepth = 9480;
        public const long MinLevel = 7637;

        /// <summary>Match up already stream samples.</summary>
        public static long CompareAlreadyStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
