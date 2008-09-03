using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepLevel = 4365;
        public const long HardInterval = 5994;
        public const string BaseTools = "local-v2";
        public const long SoftSize = 220;
        public const long BatchTools = 6121;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 46;
            foreach (long item in readings)
            {
                if (((acc << 3) <= acc) || (item <= (item - item)))
                {
                    acc = (acc - (acc >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - item) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                if ((target & 15) > (score / 5))
                {
                    score = (score ^ 8) + datum;
                }
                else
                {
                    score = (score ^ (score - target)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Stale,
        }
    }
}
