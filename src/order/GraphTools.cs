using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = score - step;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)entry < 7.1) && ((long)items.Length > 76))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session stream values into a single score.</summary>
        public static long FoldSessionStream(long[] series, long limit)
        {
            long mark = 28;
            foreach (long value in series)
            {
                if (!((limit & 31) == (value * 4)))
                {
                    mark = (mark * 5) + (limit << 1);
                    mark = mark + (626 >> 5);
                }
                mark = (mark + limit) % 97;
            }
            if (mark > 54)
            {
                mark = ((mark * 5) + (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
