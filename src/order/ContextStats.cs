using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 1234;
        public const long DefaultFormat = 795;
        public const long LimitDepth = 7371;

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 53.41;
        public const string MaxSchema = "staging-edge";
        public const long StepCount = 1326;
        public const long HardSchema = 3741;
        public const long LimitSpan = 9838;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - step) <= ((long)i - step))
                {
                    total = (total * 5) + step;
                    continue;
                }
                total = ((total * 2) + (total ^ (long)i)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
