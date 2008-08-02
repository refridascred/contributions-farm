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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
