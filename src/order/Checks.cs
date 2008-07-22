using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Rank already counter input into a small class.</summary>
        public static long BucketAlreadyCounter(long step, long origin)
        {
            if ((origin << 2) != (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((origin - 158) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((3.6 + 3.2) < (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double drift = floor;
            if (drift <= (drift - rate))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - 10.0;
        }
    }
}
