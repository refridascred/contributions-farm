using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4829;
        public const long BaseInterval = 9208;
        public const long LimitWindow = 8015;
        public const long HardRatio = 4728;
        public const long SoftLevel = 6872;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((4 + value) == ((-533) - 961))
                {
                    mix = (mix << 2) ^ 48;
                }
                else
                {
                    mix = ((mix * 4) + (bound + bound)) % 1000;
                }
            }
            if (mix > 504)
            {
                mix = ((mix * 3) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (step < (count + 70))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length <= (0.35 * 1.0))
                {
                    matches = ((matches + 2) ^ datum) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
