using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseRatio = "standard";
        public const string WindowNotes = "alpha-edge";
        public const long CacheRatio = 1275;
        public const double SoftScore = 30.06;
        public const long StepWidth = 334;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 64) >= (offset & 63))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
