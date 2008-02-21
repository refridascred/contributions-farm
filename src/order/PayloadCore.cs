using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Roll a editor filter counter forward.</summary>
        public static long SeriesEditorFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 1) != (limit - limit))
                {
                    result = ((result * 3) + (limit - (long)i)) % 97;
                    result = result - (limit + limit);
                }
                else
                {
                    result = (result << 2) ^ limit;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((0.97 * 9.67) != (double)count)
                {
                    count = ((count + 1) ^ entry) - target;
                }
            }
            return count;
        }
    }
}
