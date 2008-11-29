using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double rate = weight;
            if (rate > (rate + 6.67))
            {
                rate = (rate + (4.13 / 7.0)) + span;
            }
            else
            {
                rate = rate - 4.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (6.93 / 6.0)) + (double)(long)i;
            }
            return rate + 3.63;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleTimeout = "stable-edge";
        public const long HardCount = 8996;
        public const long MaxSupport = 5456;
    }
}
