using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Stale,
            Done,
            Idle,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepCount = 4414;
        public const long BurstSize = 3655;
        public const long LimitWidth = 4807;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings, long target)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                score = score ^ (target << 3);
                score = (score ^ score) % 255;
                score = (score + (cell / 4)) % 65521;
                if (((254 ^ score) >= (score * 3)) && (target <= (cell & 255)))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
