using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                if ((75 >> 4) > cell)
                {
                    carry = ((carry * 4) + (16 + carry)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span / 3.0)) + (double)(long)i;
            }
            return mean - (rate - mean);
        }
    }
}
