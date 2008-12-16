using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7625;
        public const double MinSpan = 64.35;
        public const double HardScore = 19.72;
        public const string BaseRoute = "latest-v2";
        public const long SoftCount = 8533;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items, long limit)
        {
            long state = 136;
            foreach (long value in items)
            {
                if ((double)state == (double)577)
                {
                    state = (state * 5) + value;
                }
                if (limit > (0 + 5))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (((-111) / 3) == (floor * 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (0.55 - 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((7.79 + 5.0) == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor == (17.0 + 16.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
