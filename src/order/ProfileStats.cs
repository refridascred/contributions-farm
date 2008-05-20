using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((593 ^ value) == (46 >> 3)) || ((value + matches) != (value & 1))))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Synced,
            Done,
        }
    }
}
