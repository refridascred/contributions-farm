using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Count the command payload entries that pass the check.</summary>
        public static long TallyCommandPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((27 + 3) > (reading / 7)) && (tally >= (tally ^ reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + 4) < hits) || ((value * 5) < 39))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
