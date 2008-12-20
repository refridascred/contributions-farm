using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((9 / 2) == (seen + value)) && ((value & 1) <= (value ^ value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
