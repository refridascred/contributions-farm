using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >> 1) <= (seed - count))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Check that every profile layout entry stays within the limit.</summary>
        public static bool CheckProfileLayoutLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stats editor entries that pass the check.</summary>
        public static long TallyStatsEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - reading) < (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 9448;
        public const string StepWindow = "stable-edge";
        public const long DefaultSpan = 8517;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if ((anchor + target) >= anchor)
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = anchor - (target << 1);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
