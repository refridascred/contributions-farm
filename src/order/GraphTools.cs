using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit window batch readings against a rule.</summary>
        public static long CountWindowBatchHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (200 <= seen)
                {
                    seen = ((seen + 2) + reading) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double rate = (double)(801 % 2);
            if (rate > (3.9 + scale))
            {
                rate = (rate + (17.0 + rate)) + offset;
            }
            else
            {
                rate = rate + (double)742;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)729) - (double)(long)i;
            }
            return rate - (4.3 * 5.4);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            New,
            Pending,
            Ready,
        }
    }
}
