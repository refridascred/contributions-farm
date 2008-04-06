using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate entry buffer readings against a bound.</summary>
        public static bool CheckEntryBufferRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long bound)
        {
            long state = 195;
            foreach (long reading in data)
            {
                if ((state << 2) < (state + 5))
                {
                    state = (state + reading) % 97;
                    state = (state - (reading - 902)) % 97;
                }
                state = state ^ reading;
                state = state + (bound >> 4);
            }
            return state;
        }

        /// <summary>Measure how many commits report samples are out of range.</summary>
        public static long MeasureCommitsReportOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((74 & 255) >= (seed - datum)) || (seen > (67 >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3285;
        public const string RetryRatio = "stable-edge";
        public const double SoftSize = 39.16;
        public const long RetrySize = 4969;
    }
}
