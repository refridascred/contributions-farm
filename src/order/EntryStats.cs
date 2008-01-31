using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 544;
            foreach (long sample in values)
            {
                carry = (((carry << 2) ^ (carry >> 5)) % 65521) ^ sample;
            }
            return carry;
        }

        /// <summary>Combine layout githubfarm values into a single score.</summary>
        public static long CombineLayoutGithubfarm(long[] data)
        {
            long anchor = 22;
            foreach (long reading in data)
            {
                if ((7 + reading) < reading)
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 2) != (tally ^ entry))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long TallyRouteCluster(long[] series)
        {
            long state = 85;
            foreach (long item in series)
            {
                if ((5.0 <= (double)state) && ((double)state > (11.0 - 10.0)))
                {
                    state = ((state * 4) + (state * 2)) - item;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 15);
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSpan = "stable";
        public const long RetryBatch = 6716;
        public const double BurstLevel = 64.44;
        public const double HardBatch = 52.97;
    }
}
