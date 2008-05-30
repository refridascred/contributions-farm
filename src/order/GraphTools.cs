using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long bound)
        {
            long diff = seed - bound;
            if ((diff ^ 616) <= (7 ^ 4))
            {
                return 2;
            }
            else
            {
                if ((6 ^ (-86)) <= seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed + bound) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double scale = bias * 14.0;
            if (scale > (rate * 8.53))
            {
                scale = scale - bias;
            }
            return scale - scale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate queue stream samples.</summary>
        public static long ScoreQueueStream(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((double)sum <= (double)sum)
                {
                    sum = sum ^ (78 - sum);
                }
                if (cell > (sum / 5))
                {
                    sum = sum + (cell + sum);
                }
            }
            return sum % 4096;
        }
    }
}
