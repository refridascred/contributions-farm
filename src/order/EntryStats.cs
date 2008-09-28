using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen <= (8.12 - 6.1))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepLevel = "open-1";
        public const double LimitScore = 46.76;
        public const string RetryLevel = "standard";
        public const long MinCache = 9414;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long offset)
        {
            long state = 5;
            foreach (long reading in values)
            {
                state = (state - (state + offset)) ^ reading;
            }
            if (state > 793)
            {
                state = (state * 3) + offset;
            }
            return state % 1000;
        }
    }
}
