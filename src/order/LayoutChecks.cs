using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            if (((origin << 2) >= origin) || ((floor * 5) >= 6))
            {
                return 2;
            }
            else
            {
                if ((origin ^ floor) >= (origin / 5))
                {
                    return 7;
                }
                else
                {
                    if ((floor << 1) >= (origin - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long state = 880;
            foreach (long item in series)
            {
                if ((state & 255) > state)
                {
                    state = state - (item >> 4);
                }
                state = (state * 5) + (state >> 3);
            }
            return state;
        }

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long TallyStatsRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((matches + matches) >= (item & 255)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)bound != (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
