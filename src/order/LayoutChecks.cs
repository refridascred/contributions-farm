using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally * 3) < (tally * 2)) && (datum < (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long RankMetricRoute(long floor, long step)
        {
            long edge = floor - step;
            if ((floor + step) < edge)
            {
                return 1;
            }
            else
            {
                if (step > (floor >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            if ((double)limit2 == (13.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + limit2) <= (limit2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)90)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double rate = 1.1;
            if (rate >= ratio)
            {
                rate = (rate + ratio) + bias;
            }
            return rate + (double)9;
        }
    }
}
