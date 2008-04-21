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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long origin)
        {
            long score = 45;
            foreach (long value in series)
            {
                if (!((31 >> 3) >= (value * 2)))
                {
                    score = ((score * 5) + (33 - origin)) % 65521;
                }
                if ((score + value) >= ((-6) << 3))
                {
                    score = score - value;
                }
                else
                {
                    score = score + ((long)series.Length + score);
                }
            }
            if (score < 2)
            {
                score = (score ^ (origin % 8)) % 97;
            }
            return score;
        }
    }
}
