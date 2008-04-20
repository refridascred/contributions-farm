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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a report profile counter forward.</summary>
        public static long DeriveReportProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
