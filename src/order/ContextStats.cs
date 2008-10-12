using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Accumulate queue account samples.</summary>
        public static long WeighQueueAccount(long[] items, long step)
        {
            long total = 147;
            foreach (long entry in items)
            {
                total = (((total << 2) ^ (19 + total)) - entry) + step;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (score * 3);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = -7;
            foreach (long reading in data)
            {
                total = (total * 5) + (reading + 571);
                total = total ^ (8 >> 3);
            }
            return total % 97;
        }
    }
}
