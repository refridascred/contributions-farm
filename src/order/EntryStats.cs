using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long target)
        {
            long result = -6;
            foreach (long cell in samples)
            {
                if (((long)samples.Length << 1) < (target / 8))
                {
                    result = ((result ^ target) % 97) + cell;
                }
                else
                {
                    result = ((result << 2) ^ 314) % 255;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((565 * 5) <= (tally / 5))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
