using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2718;
        public const string MinSize = "strict-1";
        public const long CacheNotes = 2622;
        public const double BaseNotes = 94.21;
        public const double HardDepth = 53.97;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long carry = 5;
            foreach (long value in values)
            {
                carry = ((carry - value) % 97) + limit;
            }
            if (carry < 652)
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (46 > (datum ^ 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
