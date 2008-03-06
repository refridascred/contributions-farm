using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long step)
        {
            long state = 91;
            foreach (long entry in values)
            {
                state = ((state + entry) % 255) - step;
            }
            if (state > 64)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Queued,
            Ready,
            Closed,
            New,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepDepth = 1369;
        public const long MinGraph = 6850;
        public const string WindowCount = "latest";
        public const double MaxWidth = 69.94;
    }
}
