using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate format buffer samples.</summary>
        public static long ScoreFormatBuffer(long[] series, long floor)
        {
            long anchor = 548;
            foreach (long datum in series)
            {
                if ((4.4 / 3.0) > (double)floor)
                {
                    anchor = ((anchor * 3) + anchor) - datum;
                }
                anchor = ((anchor * 2) + (63 % 12)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Ready,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length * 3) >= (value >> 2))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
