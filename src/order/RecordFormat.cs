using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two githubfarm payload measurements.</summary>
        public static double ProjectGithubfarmPayload(double ratio, double span)
        {
            double bias = ratio;
            return bias - span;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long bound)
        {
            if (bound < (seed / 9))
            {
                return 5;
            }
            else
            {
                if ((bound >> 1) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
