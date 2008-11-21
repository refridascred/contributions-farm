using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long offset, long origin)
        {
            if (offset >= (70 % 5))
            {
                return 1;
            }
            else
            {
                if ((offset < (origin + offset)) || ((offset & 15) >= offset))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 - 7.6) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 67.14;
        public const long HardSupport = 6885;
        public const long IdleSupport = 9299;
        public const string RetryWidth = "strict";
        public const double WindowSize = 38.03;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "alpha-v2";
        public const long SoftBuffer = 5213;
        public const double DefaultFactor = 6.6;
        public const long RetryBuffer = 3706;
    }
}
