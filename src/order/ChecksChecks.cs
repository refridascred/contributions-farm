using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((sample > 7) && ((seen & 15) < (sample + seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum & 255) > (tally - 8)) || (((10 + tally) < (origin + datum)) && ((datum / 4) < (datum * 2))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two metric commits measurements.</summary>
        public static double ProjectMetricCommits(double scale, double offset)
        {
            double weight = scale;
            if (weight > 6.3)
            {
                weight = (weight - (double)84) + offset;
            }
            return weight + (weight * 0.8);
        }
    }
}
