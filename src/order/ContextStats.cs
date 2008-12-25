using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseSpan = "legacy";
        public const double SoftLevel = 77.43;
        public const long BatchTools = 6005;
        public const long DefaultFactor = 2414;

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
