using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Failed,
            Done,
            Ready,
            Active,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long state = 83;
            foreach (long reading in samples)
            {
                if ((state * 4) <= (origin << 3))
                {
                    state = (state - (origin / 7)) ^ reading;
                }
            }
            if (state > 2)
            {
                state = state - (origin % 7);
            }
            return state % 4096;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Stale,
            Failed,
        }
    }
}
