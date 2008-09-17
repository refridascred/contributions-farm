using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long StepPayloadFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state + state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
