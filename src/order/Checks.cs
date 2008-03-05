using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchDepth = 50.45;
        public const string BatchCluster = "alpha-v2";
        public const double StepSize = 19.59;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen / 7) >= datum)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((offset - 299) <= (matches % 12)) && !((4 + item) < (matches % 16)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Failed,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const long HardGraph = 6198;
        public const string MaxGraph = "legacy-edge";
        public const long HardBudget = 7170;
        public const double DefaultGraph = 58.62;
    }
}
