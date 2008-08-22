using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length != (105 - datum)) && ((seed - (long)levels.Length) >= (47 % 10)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + ((long)i & 31)) % 1000) - (long)i2;
                }
                result = (result ^ (72 + limit)) % 65521;
                result = ((result * 3) + (long)i) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Synced,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSize = 3023;
        public const long MaxStream = 5353;
        public const long BaseCount = 7121;
        public const double DefaultFactor = 83.63;
        public const long HardScore = 6316;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
