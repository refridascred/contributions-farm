using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long TallyEntryMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((14.0 / 5.0) < (double)matches) && ((double)matches <= (1.7 * 4.87)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((hits / 7) > hits) && ((reading - bound) >= bound)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "stable";
        public const string BurstNotes = "local-edge";
        public const long WindowNotes = 4007;
        public const long WindowLevel = 4923;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long DeriveQueueCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                long edge = carry;
                carry = ((carry << 3) ^ (floor ^ edge)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
