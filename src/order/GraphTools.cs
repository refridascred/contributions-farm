using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool CheckMetricNotesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long floor)
        {
            long result = 194;
            foreach (long value in samples)
            {
                result = (result ^ floor) + value;
            }
            return result;
        }

        /// <summary>Iterate the context stats series from a seed.</summary>
        public static long RollContextStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (-19);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
