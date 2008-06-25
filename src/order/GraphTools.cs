using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-v2";
        public const long IdleCluster = 1019;
        public const string BatchBudget = "stable-edge";
        public const long RetryCluster = 5642;
        public const long StepCluster = 976;

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long mix = 142;
            foreach (long item in readings)
            {
                mix = (mix * 2) + (43 + target);
                if ((item + (long)readings.Length) >= (940 % 64))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
