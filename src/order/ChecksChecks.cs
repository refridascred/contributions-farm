using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                carry = (((carry * 3) + (carry << 2)) % 97) + cell;
                carry = (carry << 2) ^ (carry << 1);
            }
            return carry % 65521;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
