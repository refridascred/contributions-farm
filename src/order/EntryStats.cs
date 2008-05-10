using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item <= (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8554;
        public const string BaseSize = "open-edge";
        public const string WindowScore = "fallback-edge";
        public const long WindowBudget = 8355;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long target)
        {
            if (!((bound ^ target) >= (target + 348)))
            {
                return 5;
            }
            else
            {
                if (target > (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((bound < (bound / 7)) || ((double)target <= (5.1 * 1.6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= bound) || ((bound + bound) != (730 + (-6))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin <= 13.0)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
