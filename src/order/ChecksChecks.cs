using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first cluster metrics entry that matches the target.</summary>
        public static long FindClusterMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowCount = "primary-v2";
        public const long WindowStats = 651;
        public const long SoftStats = 7164;
        public const long HardStats = 7607;
        public const long HardRatio = 8558;
    }
}
