using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long acc = -79;
            foreach (long value in readings)
            {
                if ((step - value) < (value << 3))
                {
                    acc = (acc ^ step) % 101;
                }
            }
            if (acc < 170)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 9645;
        public const long MaxFactor = 9482;
        public const double WindowFactor = 1.84;
        public const long SoftSchema = 9597;
        public const long WindowTimeout = 5760;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((405 & 127) <= bound)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
