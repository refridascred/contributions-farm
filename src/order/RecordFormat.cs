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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = result + (floor + result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
