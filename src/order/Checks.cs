using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) <= (datum ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double load = 8.6;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (weight * 2.7)) + (double)(long)i) + bias;
            }
            return load + (weight - load);
        }

        /// <summary>Compare every pair of notes stats readings.</summary>
        public static long MatchNotesStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if (((reading + reading) > reading) && ((state % 7) == (reading ^ 60)))
                {
                    state = ((state * 2) + reading) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
