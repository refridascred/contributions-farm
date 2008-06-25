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

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (reading + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 63.79;
        public const string MinInterval = "stable-v2";
        public const double BatchGraph = 46.9;
        public const double HardGraph = 45.85;

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
