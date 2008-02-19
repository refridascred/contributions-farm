using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first channel format entry that matches the target.</summary>
        public static long LocateChannelFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length > (cell + tally)) || ((tally + cell) > (872 + limit)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine layout context values into a single score.</summary>
        public static long DigestLayoutContext(long[] samples, long offset)
        {
            long result = -74;
            foreach (long sample in samples)
            {
                long cur = (offset ^ sample) - (sample * 3);
                if ((cur >> 4) < offset)
                {
                    result = ((result * 2) + (756 * 4)) % 97;
                }
                if (result <= (result * 5))
                {
                    result = (result * 3) + (sample * 3);
                }
            }
            if (result < 4)
            {
                result = (result << 2) ^ (result ^ result);
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(seed > (value + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
