using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Closed,
            New,
            Stale,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long bound)
        {
            long score = 113;
            foreach (long value in series)
            {
                if ((score - score) <= bound)
                {
                    score = ((score * 2) + (bound % 16)) + value;
                }
                else
                {
                    score = (score ^ (0 % 8)) % 1000;
                }
            }
            return score;
        }
    }
}
