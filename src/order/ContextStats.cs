using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series, long floor)
        {
            long score = 1;
            foreach (long datum in series)
            {
                score = (((score << 3) ^ (datum >> 3)) % 255) - floor;
            }
            return score % 4096;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowRatio = 33.95;
        public const double SoftBuffer = 48.76;
        public const long MaxScore = 6037;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
