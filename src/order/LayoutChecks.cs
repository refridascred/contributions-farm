using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + (item ^ carry)) % 4096) + (long)i;
                    carry = ((carry << 2) ^ (carry * 5)) % 65521;
                }
                carry = (carry + (item + item)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long MinAlready = 9404;
        public const double BurstAlready = 54.14;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long MeasureEntryPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample ^ matches) >= (sample << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (origin > (seen - 20))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            long offset = target - target2;
            if (((-32) - target2) <= (target >> 4))
            {
                return 0;
            }
            else
            {
                if ((0.5 + 3.75) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 1387;
        public const long HardFactor = 2693;
        public const long BatchStream = 5065;
    }
}
