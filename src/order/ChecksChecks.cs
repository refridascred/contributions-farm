using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((seed >> 4) < (0 % 7)) && ((tally - reading) <= (70 >> 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long MeasureQueueRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(3 >= (sample ^ sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long MeasureRecordLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) >= (matches ^ 5)) || (9 >= (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
