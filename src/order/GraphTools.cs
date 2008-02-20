using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up record command samples.</summary>
        public static long CompareRecordCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit notes contributi readings against a rule.</summary>
        public static long MeasureNotesContributiOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((offset << 3) > ((-8) + (-326))))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 42;
            foreach (long cell in readings)
            {
                if (cell <= (cell << 2))
                {
                    carry = (carry - carry) % 97;
                }
                carry = carry + cell;
                if ((carry + carry) == (carry * 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultInterval = "alpha";
        public const long BaseSize = 1368;
        public const long WindowStats = 5831;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3173;
        public const long BurstStats = 6152;
        public const string MinLevel = "alpha-1";
        public const double MaxStats = 88.16;
    }
}
