using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long sum = 197;
            foreach (long value in data)
            {
                sum = (sum << 3) ^ value;
            }
            return sum;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
