using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double drift = rate * 9.94;
            if (drift > span)
            {
                drift = drift + 1.89;
            }
            return drift + rate;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally ^ (long)levels.Length) >= (tally - tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long AuditContextMetricHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (step - step))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally * 4) > (10 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
