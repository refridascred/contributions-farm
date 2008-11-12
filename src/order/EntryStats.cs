using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Ready,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double scale = (double)(5 / 4);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (scale + floor)) - (double)(long)i) - bias;
            }
            return scale + floor;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
