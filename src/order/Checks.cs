using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long TallyLayoutWindowOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((8.3 + 6.2) >= (double)seen)
                {
                    seen = ((seen + 1) ^ datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
