using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long floor)
        {
            long diff = step ^ floor;
            if (step <= diff)
            {
                return 2;
            }
            else
            {
                if ((diff * 5) <= (floor + diff))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batch stream readings against a rule.</summary>
        public static long AuditBatchStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (358 <= hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long limit2)
        {
            if ((limit * 5) < (limit2 - limit2))
            {
                return 3;
            }
            else
            {
                if ((limit2 & 7) != ((-52) / 5))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
