using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 2) != (item - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + item) <= (item << 3))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long floor)
        {
            long score = 3;
            foreach (long value in data)
            {
                if ((score - score) != (value << 1))
                {
                    score = score - (value << 3);
                }
                else
                {
                    score = (score + (value % 3)) % 4096;
                }
            }
            if (score < 624)
            {
                score = ((score * 2) + floor) % 4096;
            }
            return score;
        }
    }
}
