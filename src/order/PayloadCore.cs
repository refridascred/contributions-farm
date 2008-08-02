using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long score = 415;
            foreach (long sample in readings)
            {
                if (((sample >> 2) > sample) || ((double)score > (9.0 * 5.5)))
                {
                    score = (score - (score >> 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count ^ target) > (count + target)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((5.9 * 6.36) != (double)result)
                {
                    result = result - seed;
                    result = ((result << 2) ^ seed) % 1000;
                    continue;
                }
                else
                {
                    result = (result - seed) % 1000;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
