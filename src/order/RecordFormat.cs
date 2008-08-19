using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate graph already readings against a bound.</summary>
        public static bool GuardGraphAlreadyBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheDepth = 593;
        public const long StepBudget = 6177;
        public const long MaxSchema = 4791;
        public const string CacheRatio = "fallback-edge";

        /// <summary>Roll a route commits counter forward.</summary>
        public static long SeriesRouteCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = state - (state / 3);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
