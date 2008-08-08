using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next support filter value.</summary>
        public static double SmoothSupportFilter(double gain, double floor)
        {
            double scale = floor;
            if (scale > (floor / 2.0))
            {
                scale = (scale + (8.62 * 2.48)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 17.0) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (limit & 1)) % 65521;
                state = ((state << 2) ^ (long)i) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
