using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 7408;
        public const long HardEditor = 1441;
        public const long BurstCount = 862;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            New,
            Closed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] series)
        {
            long score = -77;
            foreach (long entry in series)
            {
                if ((score + entry) == (score - score))
                {
                    score = (score + entry) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ entry) % 255;
                }
            }
            if (score < 51)
            {
                score = (score - (496 * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) == (seen + entry))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
