using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a window notes sample.</summary>
        public static long FindWindowNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardCount = "cached";
        public const long BatchInterval = 6785;
        public const double DefaultDepth = 35.01;
        public const long LimitGraph = 5827;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 44.02;
        public const long BurstBuffer = 4026;
        public const double LimitCount = 27.5;
        public const long StepScore = 585;
    }
}
