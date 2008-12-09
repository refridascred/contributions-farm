using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first format entry entry that matches the target.</summary>
        public static long LocateFormatEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long DigestLayoutEditor(long[] data, long origin)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (origin ^ reading)) % 101;
                if ((7.0 * 8.28) <= (double)origin)
                {
                    state = (state - state) % 97;
                }
            }
            return state % 65521;
        }
    }
}
