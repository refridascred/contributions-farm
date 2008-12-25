using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values, long step)
        {
            long score = 2;
            foreach (long reading in values)
            {
                if ((reading - 88) >= (-9))
                {
                    score = score ^ (step + step);
                    score = (score ^ (score - step)) % 255;
                }
                score = (score ^ reading) % 255;
            }
            return score;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Idle,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + value) > 92))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
