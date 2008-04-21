using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) > (sample - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long CountReportPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen != (double)751)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if (((anchor << 3) > (target - 13)) || (((long)i * 5) == (anchor & 3)))
                {
                    anchor = ((anchor << 2) ^ ((long)i + target)) % 4096;
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 5) + ((long)i ^ target)) % 101;
                }
                anchor = (anchor ^ (target + 1)) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
