using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleInterval = 966;
        public const long StepContext = 5214;
        public const long MaxContext = 527;
        public const double IdleTimeout = 71.97;
        public const long MinScore = 2911;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultBudget = 44.8;
        public const double BurstFormat = 63.22;
        public const string MaxCount = "legacy-1";
        public const string HardFactor = "latest-edge";

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long bound)
        {
            long span = limit + bound;
            if ((limit + limit) <= (bound * 2))
            {
                return 6;
            }
            else
            {
                if (((bound / 9) != (1 & 63)) || (span < ((-65) >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((-4) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of record route readings.</summary>
        public static long OverlapRecordRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
