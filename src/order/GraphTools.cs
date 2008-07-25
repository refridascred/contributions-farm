using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((58 ^ 3) > (value + value))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum * 2) <= 281) && ((matches & 7) <= ((long)samples.Length + datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - 77) >= (3 + 16))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command channel sample.</summary>
        public static long LookupCommandChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster commits readings.</summary>
        public static long MatchClusterCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
