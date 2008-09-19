using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 9236;
        public const long LimitSize = 8169;
        public const long HardSize = 7583;
        public const long HardScore = 5716;
        public const long DefaultCounter = 8325;
    }
}
