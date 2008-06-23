using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally >= (floor % 8))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((4.78 / 8.0) > (double)sample))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((342 ^ hits) >= hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Dropped,
        }
    }
}
