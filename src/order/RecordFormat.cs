using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Ready,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Measure how many token payload samples are out of range.</summary>
        public static long TallyTokenPayloadOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((1.3 - 7.6) > (0.6 - 3.0))
                {
                    matches = ((matches + 2) + entry) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate farm route readings against a bound.</summary>
        public static bool VerifyFarmRouteBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Done,
        }
    }
}
