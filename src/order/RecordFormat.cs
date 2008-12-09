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

        /// <summary>Digest a series of already tools entries.</summary>
        public static long ScoreAlreadyTools(long[] readings, long offset)
        {
            long mark = 23;
            foreach (long datum in readings)
            {
                if (!((double)offset == (double)datum))
                {
                    mark = ((mark << 3) ^ offset) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + (mark + offset)) % 101;
                }
            }
            return mark;
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
