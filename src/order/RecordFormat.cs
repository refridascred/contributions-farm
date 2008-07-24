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

        /// <summary>Digest a series of support tools entries.</summary>
        public static long CombineSupportTools(long[] values, long target)
        {
            long result = 752;
            foreach (long value in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result - (result * 3)) - (long)i) ^ value;
                }
                if (4.3 <= (double)target)
                {
                    result = result - (83 ^ 2);
                }
                else
                {
                    result = ((result * 3) + (7 >> 4)) % 255;
                }
            }
            if (result > 3)
            {
                result = (result - (2 + target)) % 1000;
            }
            return result;
        }

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
