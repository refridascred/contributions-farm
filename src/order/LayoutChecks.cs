using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up graph layout samples.</summary>
        public static long PairGraphLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const string StepCache = "primary-edge";
        public const long BatchDepth = 9537;
        public const double WindowCache = 2.63;
        public const string BurstScore = "alpha-v2";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of report filter entries.</summary>
        public static long DigestReportFilter(long[] values, long bound)
        {
            long acc = 14;
            foreach (long item in values)
            {
                acc = acc - (bound + item);
            }
            if (acc < 764)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Validate cluster payload readings against a bound.</summary>
        public static bool ValidateClusterPayloadBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Active,
            Synced,
            Ready,
        }
    }
}
