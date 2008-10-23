using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Pending,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((bound > (bound2 + bound)) && ((bound ^ bound) >= (bound2 - bound2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 <= (19.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 6) != (bound2 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound2 & 31) <= bound2) && ((bound + bound) <= (bound + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool VerifyNotesBatchesBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 875;
        public const long BaseRecord = 9509;
        public const long HardLevel = 2726;
        public const double WindowSpan = 78.42;
        public const long LimitRecord = 3455;
    }
}
