using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long floor)
        {
            if ((target >> 3) <= target)
            {
                return 3;
            }
            else
            {
                if (((target + target) <= (target >> 2)) || ((double)target <= (1.7 + 2.7)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
