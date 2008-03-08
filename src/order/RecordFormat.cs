using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next session cluster value from a seed.</summary>
        public static long DeriveSessionCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values, long offset)
        {
            long mark = 670;
            foreach (long entry in values)
            {
                if ((offset & 31) >= entry)
                {
                    mark = ((mark << 2) ^ (entry - mark)) % 101;
                }
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark - (29 + (long)i)) % 101;
                }
                if (offset > (long)values.Length)
                {
                    mark = (mark - (entry - offset)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Retry,
            Locked,
            New,
            Idle,
        }
    }
}
