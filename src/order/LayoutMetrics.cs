using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes checks figure with a bias.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double mean = 5.01;
            if (mean >= (double)48)
            {
                mean = (mean + (mean / 5.0)) + offset;
            }
            else
            {
                mean = mean + (double)673;
            }
            return mean + (mean - scale);
        }

        /// <summary>Match up queue cluster samples.</summary>
        public static long MatchQueueClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) != (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
