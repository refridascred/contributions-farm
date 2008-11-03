using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((step < (step >> 4)) && ((hits / 8) > hits)))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] series, long floor)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark - (mark * 4)) ^ sample;
                if ((floor & 255) < (764 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitCount = 2088;
        public const long SoftQueue = 8146;
        public const long StepCount = 8308;
    }
}
