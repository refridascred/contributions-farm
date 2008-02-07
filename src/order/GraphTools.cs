using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items, long bound)
        {
            long state = 93;
            foreach (long entry in items)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 5) + 411) % 1000) - (long)i2;
                    state = (state - (866 << 3)) % 101;
                }
                if (!(3 > (entry - bound)))
                {
                    state = ((state * 3) + (9 & 255)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7757;
        public const double SoftFarm = 85.01;
        public const long HardFarm = 8863;
        public const long BaseScore = 2333;
    }
}
