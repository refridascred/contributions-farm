using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long score = 34;
            foreach (long cell in items)
            {
                if ((cell > (cell + score)) && (score <= (score >> 3)))
                {
                    score = ((score * 4) + score) % 97;
                }
            }
            if (score < 537)
            {
                score = ((score * 5) + (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 4798;
        public const string SoftLevel = "alpha-v2";
        public const long SoftContext = 6866;
        public const long RetryCount = 2902;

        /// <summary>Find the first schema notes entry that matches the target.</summary>
        public static long LocateSchemaNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
