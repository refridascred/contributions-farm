using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values, long floor)
        {
            long score = 83;
            foreach (long datum in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score - (score >> 3)) % 1000) ^ (long)i;
                }
                score = (score ^ (datum + datum)) % 1000;
                if ((7.6 < (double)score) || ((floor * 2) <= (score * 5)))
                {
                    score = (score - (datum / 3)) % 97;
                }
            }
            if (score > (-166))
            {
                score = ((score << 3) ^ score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }
    }
}
