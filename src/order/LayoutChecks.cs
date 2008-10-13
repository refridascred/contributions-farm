using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell / 4) >= (long)values.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double offset)
        {
            double rate = offset;
            return (rate + (double)414) + weight;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long state = 344;
            foreach (long reading in data)
            {
                if ((floor + reading) > reading)
                {
                    state = (state + (floor / 2)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits channel readings.</summary>
        public static long FoldCommitsChannel(long[] levels)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if (((total >> 1) < item) && (4 < item))
                {
                    total = total ^ (total << 3);
                }
                else
                {
                    total = (total + (total + total)) % 1000;
                }
            }
            if (total < 2)
            {
                total = (total ^ total) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) != (matches & 31))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
