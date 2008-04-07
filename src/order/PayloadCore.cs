using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + 67) != (origin << 2))
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (8 / 8);
                    state = ((state * 5) + origin) % 1000;
                }
                state = state ^ state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Dropped,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
