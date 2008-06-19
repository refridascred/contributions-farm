using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            if (762 > seed)
            {
                return 1;
            }
            else
            {
                if (((double)67 >= (6.77 / 6.0)) && ((double)seed <= 19.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
