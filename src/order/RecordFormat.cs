using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally == (20.0 * 7.48))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long bound)
        {
            if ((step + bound) >= (85 + bound))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (8.47 / 2.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound <= (16.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long StepStatsCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (carry >> 3)) % 97;
                carry = (carry ^ (carry * 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((floor * 5) > (matches + 30)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
