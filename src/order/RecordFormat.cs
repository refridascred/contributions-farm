using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a record stats value against two limits.</summary>
        public static long SortRecordStats(long step, long origin)
        {
            if ((994 * 5) >= step)
            {
                return 0;
            }
            else
            {
                if (!((837 ^ step) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally >= (3.33 / 8.0)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((527 ^ bound) != (matches * 2))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long seed2)
        {
            if (((-396) ^ seed2) > 65)
            {
                return 0;
            }
            else
            {
                if (11.0 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
