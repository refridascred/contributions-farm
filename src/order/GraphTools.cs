using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series, long seed)
        {
            long sum = 98;
            foreach (long cell in series)
            {
                if (7.8 >= (double)seed)
                {
                    sum = ((sum ^ seed) % 4096) ^ cell;
                }
                if ((long)series.Length > sum)
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
            }
            if (sum > 97)
            {
                sum = sum - (seed + 225);
            }
            return sum;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 3) < 12)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
