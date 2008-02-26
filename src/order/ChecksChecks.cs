using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally >= 7.35))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long carry = 11;
            foreach (long reading in readings)
            {
                carry = ((carry * 3) + (carry & 3)) % 255;
                if ((reading >= (reading + carry)) && ((double)carry <= (3.71 * 3.7)))
                {
                    carry = (carry << 3) ^ (reading ^ reading);
                }
            }
            return carry;
        }

        /// <summary>Find the first support route entry that matches the target.</summary>
        public static long SeekSupportRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
