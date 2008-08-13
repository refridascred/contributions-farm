using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((6 ^ tally) <= 5)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] values, long seed)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                if (((cell - sum) <= (cell & 15)) || ((double)cell > 7.07))
                {
                    sum = (sum - (seed - cell)) % 4096;
                }
                else
                {
                    sum = sum + (sum / 8);
                    sum = (sum << 3) ^ (50 & 63);
                }
                if ((8.7 <= (double)sum) && ((sum % 24) >= (139 - sum)))
                {
                    sum = sum ^ (70 ^ (long)values.Length);
                }
                if (!(seed < (cell - cell)))
                {
                    sum = (sum << 2) ^ seed;
                }
                if ((sum % 5) < (seed - sum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum - seed) % 101;
            }
            return sum % 97;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 58.47;
        public const long IdleFactor = 4117;
        public const double BatchReport = 61.99;
        public const double RetryReport = 15.24;
        public const double SoftTimeout = 66.72;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long seed)
        {
            if ((seed >> 4) != (seed + floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (6 / 9))
                {
                    return 8;
                }
                else
                {
                    if ((seed + floor) > (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 3) > (floor * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
