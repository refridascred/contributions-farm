using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (anchor >= (origin - (long)i))
                {
                    anchor = (anchor << 3) ^ (721 % 5);
                    break;
                }
                if (anchor > ((long)i + anchor))
                {
                    anchor = (anchor << 2) ^ (284 + 45);
                    anchor = (anchor << 2) ^ (origin >> 5);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double drift = 0.15;
            if (drift > (double)332)
            {
                drift = (drift - 8.2) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
