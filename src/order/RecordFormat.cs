using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6184;
        public const long BurstDepth = 3063;
        public const string BurstLevel = "legacy-1";
        public const string BurstNotes = "standard";

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ datum) >= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long bound)
        {
            long bound2 = target + bound;
            if ((double)bound2 >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((bound2 ^ target) < (bound2 >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((960 >= bound) && ((double)bound <= (8.3 + 14.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - target) != (bound / 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
