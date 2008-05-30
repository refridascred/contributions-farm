using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally ^ tally) != (tally * 3))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches < (matches + matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = 48;
            foreach (long datum in levels)
            {
                sum = (sum - (datum << 2)) % 97;
                if ((datum <= (datum ^ (-2))) || ((2.7 * 0.07) <= (double)datum))
                {
                    sum = ((sum * 5) + sum) % 4096;
                }
            }
            return sum;
        }
    }
}
