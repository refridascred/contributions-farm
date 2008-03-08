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

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
