using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score + score) - entry;
            }
            return score;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 8823;
        public const long WindowEntry = 932;
        public const long LimitTimeout = 1965;
        public const long WindowDepth = 7225;
        public const long MaxScore = 5999;
    }
}
