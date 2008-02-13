using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of already payload readings.</summary>
        public static long ScoreAlreadyPayload(long[] series)
        {
            long state = 923;
            foreach (long datum in series)
            {
                state = ((state * 3) + (state + datum)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Dropped,
            Done,
            Active,
            Failed,
        }

        /// <summary>Iterate the payload schema series from a seed.</summary>
        public static long StepPayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - seed) != (1 % 5))
                {
                    result = (result * 3) + (seed ^ result);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
