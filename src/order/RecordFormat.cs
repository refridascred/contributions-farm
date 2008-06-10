using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 8576;
        public const double BaseRatio = 3.18;
        public const long WindowTimeout = 81;
        public const double MinDepth = 35.94;
        public const double RetryCommits = 47.48;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - 16) < (seen - value)) || ((87 >> 4) > (seen << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long origin2)
        {
            if ((origin2 >= (origin + origin2)) && ((double)origin2 >= (double)17))
            {
                return 2;
            }
            else
            {
                if ((origin2 << 1) != (852 - origin))
                {
                    return 0;
                }
                else
                {
                    if (!(origin < (246 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
