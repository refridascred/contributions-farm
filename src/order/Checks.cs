using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long AuditBatchAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell > 0)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data)
        {
            long score = 58;
            foreach (long cell in data)
            {
                score = (score - cell) % 1000;
            }
            if (score < 37)
            {
                score = ((score * 2) + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long MeasureBatchesFormatMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count >= (17.0 + 20.0))
                {
                    count = ((count + 1) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
