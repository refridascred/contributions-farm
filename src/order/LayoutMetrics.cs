using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally % 2) >= (576 - (long)levels.Length))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = -100;
            foreach (long cell in levels)
            {
                if ((cell & 7) <= 59)
                {
                    total = (total * 5) + (total & 31);
                    total = (total + total) % 255;
                }
                total = (total * 3) + (total / 2);
                if (15.0 >= (double)total)
                {
                    total = (total - (total / 5)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (cell + total)) % 101;
                }
            }
            return total % 97;
        }
    }
}
