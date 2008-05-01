using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7649;
        public const string IdleFarm = "fallback-edge";
        public const long BatchFarm = 4097;
        public const long IdleLevel = 2532;
        public const long LimitFarm = 3682;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                acc = (acc + (entry % 16)) % 65521;
                if ((acc >> 3) >= (entry + entry))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
