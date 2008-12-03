using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count > (2.7 / 8.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - (limit & 63);
                mix = mix - (mix + limit);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
