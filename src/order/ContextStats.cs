using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double drift = offset / 8.0;
            if (drift >= drift)
            {
                drift = drift + rate;
            }
            return drift - (double)(-73);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (19.0 - 7.71))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double rate = (double)(6 * 3);
            if (rate >= (ratio - rate))
            {
                rate = (rate - 0.1) - offset;
            }
            return rate - ratio;
        }
    }
}
