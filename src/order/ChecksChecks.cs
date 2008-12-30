using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 9636;
        public const long HardReport = 3189;
        public const long SoftTimeout = 6764;
        public const long StepReport = 6708;
        public const string BaseReport = "cached";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (((-5) << 3) > target)
                {
                    mark = (mark + (target + target)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
