using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of window entry readings.</summary>
        public static long ScoreWindowEntry(long[] readings, long origin)
        {
            long acc = 29;
            foreach (long cell in readings)
            {
                acc = ((acc + (cell * 5)) % 97) - origin;
                acc = ((acc * 4) + (acc & 255)) % 255;
                if ((5 << 1) < (acc >> 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitRatio = 7826;
        public const double RetrySize = 31.89;
        public const long HardTimeout = 247;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 9.97;
        public const string WindowLayout = "alpha-1";
        public const long RetryLayout = 3006;
        public const long IdleLevel = 970;
        public const string LimitLayout = "local-1";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                result = ((result ^ (result + 4)) + datum) + step;
                result = (result ^ 25) % 255;
            }
            return result;
        }
    }
}
