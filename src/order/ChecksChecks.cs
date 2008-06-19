using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 74;
            foreach (long value in readings)
            {
                mix = (mix + value) % 101;
            }
            return mix;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 224;
        public const long MinBudget = 2706;
        public const long MaxSupport = 6898;
    }
}
