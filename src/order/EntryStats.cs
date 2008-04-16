using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches + sample) > ((-9) * 3)) || (((sample ^ matches) <= matches) && ((double)sample == (3.6 / 2.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4 >= (hits + 76)) && (cell <= (86 & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
