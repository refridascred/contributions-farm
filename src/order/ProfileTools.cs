using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate session commits readings against a bound.</summary>
        public static bool VerifySessionCommitsBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next format counter value from a seed.</summary>
        public static long RollFormatCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((287 + origin) != ((-91) + 146))
                {
                    mark = ((mark << 3) ^ 88) % 1000;
                }
                if (((mark / 6) <= (origin & 1)) || (mark >= (origin - (long)i)))
                {
                    mark = (mark + mark) % 255;
                    mark = ((mark * 4) + (origin - mark)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long sum = 49;
            foreach (long sample in series)
            {
                if ((sample ^ sum) == ((long)series.Length & 255))
                {
                    break;
                }
                sum = (((sum * 2) + (723 / 2)) % 97) + seed;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5554;
        public const string BaseTimeout = "primary-v2";
        public const string DefaultDepth = "latest-1";
        public const long HardRoute = 3964;
    }
}
