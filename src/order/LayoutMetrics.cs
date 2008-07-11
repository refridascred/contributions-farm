using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm schema readings against a rule.</summary>
        public static long CountGithubfarmSchemaGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)seed != (double)entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
