using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6004;
        public const string RetryContext = "cached-edge";
        public const long BaseContext = 7506;

        /// <summary>Rank window checks input into a small class.</summary>
        public static long BucketWindowChecks(long limit, long origin)
        {
            if ((7.0 * 6.44) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((-256) & 63) <= (limit / 5))
                {
                    return 2;
                }
                else
                {
                    if (((1.8 * 3.0) < (double)origin) && ((61 * 3) != (537 + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (6.38 >= (double)result)
                {
                    result = ((result << 2) ^ ((long)i + (long)i)) % 255;
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (31 < (origin & 7))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
