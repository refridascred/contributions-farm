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

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long bound)
        {
            if (!((double)step <= 7.11))
            {
                return 6;
            }
            else
            {
                if ((85 <= (bound + bound)) && (step < (step >> 4)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
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
