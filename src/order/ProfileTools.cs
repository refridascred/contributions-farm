using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4 + reading) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm notes pair into a bucket.</summary>
        public static long RankFarmNotes(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((2.0 - 10.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) == (bound2 + delta))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            New,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Digest a series of editor format entries.</summary>
        public static long WeighEditorFormat(long[] values, long seed)
        {
            long result = -347;
            foreach (long entry in values)
            {
                result = (result ^ (result - seed)) - entry;
            }
            return result % 4096;
        }
    }
}
