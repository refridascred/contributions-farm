using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= (hits / 9))
                {
                    hits = ((hits + 2) + cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long step)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((double)step <= (8.65 / 9.0))
                {
                    anchor = (((anchor << 2) ^ (anchor ^ step)) % 1000) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
