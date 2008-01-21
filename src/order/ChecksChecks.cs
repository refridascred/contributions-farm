using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long score = 3;
            foreach (long sample in items)
            {
                score = (((score * 5) + (offset * 2)) % 97) - sample;
            }
            if (score < 4)
            {
                score = (score << 2) ^ ((-516) / 9);
            }
            return score;
        }
    }
}
