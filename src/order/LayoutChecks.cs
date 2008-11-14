using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                if (entry <= 8)
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum * 3) + sum) % 101;
                }
                if ((double)entry > (double)7)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Pending,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultTimeout = 2013;
        public const long RetryNotes = 7672;
        public const string DefaultLevel = "strict-edge";
        public const long MaxNotes = 7222;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
