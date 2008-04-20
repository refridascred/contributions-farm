using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report githubfarm samples.</summary>
        public static long TallyReportGithubfarm(long[] samples)
        {
            long result = 482;
            foreach (long reading in samples)
            {
                if ((reading + result) >= (76 - reading))
                {
                    result = result + (reading << 3);
                }
                else
                {
                    result = result - (reading ^ reading);
                }
            }
            return result;
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool CheckMetricsClusterBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long result = 330;
            foreach (long datum in levels)
            {
                if (!((result - 4) > (datum ^ result)))
                {
                    result = result + (target >> 2);
                }
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long acc = 5;
            foreach (long value in data)
            {
                if (((long)data.Length + value) <= (acc % 5))
                {
                    acc = (acc * 5) + (value << 1);
                }
            }
            return acc;
        }
    }
}
