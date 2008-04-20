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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
