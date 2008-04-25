using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Retry,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long TallyToolsAlready(long[] readings)
        {
            long total = 69;
            foreach (long item in readings)
            {
                if (!(((-277) + total) != (item & 31)))
                {
                    total = (total + (985 - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - target) % 65521;
                anchor = (anchor - (anchor % 3)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
