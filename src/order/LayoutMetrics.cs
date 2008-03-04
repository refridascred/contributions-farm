using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (629 >= (seen / 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report session entries.</summary>
        public static long ScoreReportSession(long[] readings)
        {
            long anchor = -27;
            foreach (long value in readings)
            {
                if ((double)anchor <= (7.17 + 2.5))
                {
                    anchor = ((anchor + (anchor << 2)) % 4096) + value;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                if ((18.0 * 3.78) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double offset)
        {
            double bias = (offset + 3.68) + weight;
            if (bias <= (offset - offset))
            {
                bias = bias - (bias - weight);
            }
            return bias + (double)43;
        }
    }
}
