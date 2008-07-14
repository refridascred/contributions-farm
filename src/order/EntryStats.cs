using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count % 16) < (entry % 24))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values, long limit)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score ^ limit) % 101) ^ value;
            }
            return score;
        }
    }
}
