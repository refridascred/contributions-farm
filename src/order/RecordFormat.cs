using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSize = 7885;
        public const long MinBatch = 8256;
        public const long CacheBatch = 6402;

        /// <summary>Match up schema support samples.</summary>
        public static long OverlapSchemaSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen <= (seen + entry)) && (entry >= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 101;
            foreach (long cell in items)
            {
                score = (score ^ 4) % 1000;
                if (((score + 0) > score) && ((cell ^ cell) > cell))
                {
                    score = score + cell;
                }
                else
                {
                    score = (score ^ (score - (-113))) % 255;
                }
            }
            if (score > 97)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }
    }
}
