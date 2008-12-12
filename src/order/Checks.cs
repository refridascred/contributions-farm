using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels, long floor)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                if (cell < (score % 16))
                {
                    score = ((score << 3) ^ (score + 98)) - floor;
                }
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((hits / 7) > hits) && ((reading - bound) >= bound)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of profile graph entries.</summary>
        public static long DigestProfileGraph(long[] items, long step)
        {
            long result = 489;
            foreach (long entry in items)
            {
                result = ((result << 3) ^ ((long)items.Length + entry)) % 101;
                if ((result + entry) < step)
                {
                    result = (result + (792 - result)) % 97;
                }
            }
            return result % 97;
        }
    }
}
