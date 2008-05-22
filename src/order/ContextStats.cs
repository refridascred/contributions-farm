using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "standard";
        public const string HardDepth = "local-edge";
        public const long LimitChannel = 8755;
        public const long HardFactor = 1991;

        /// <summary>Check that every queue graph entry stays within the limit.</summary>
        public static bool ValidateQueueGraphRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= 6)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
