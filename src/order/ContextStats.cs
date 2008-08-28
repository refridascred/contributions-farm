using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            New,
            Active,
            Queued,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long state = 8;
            foreach (long item in series)
            {
                if ((state % 24) < item)
                {
                    state = ((state * 4) + 95) % 4096;
                }
            }
            if (state > 650)
            {
                state = (state << 2) ^ (state * 5);
            }
            return state;
        }
    }
}
