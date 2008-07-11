using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 1) == (datum - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm schema readings against a rule.</summary>
        public static long CountGithubfarmSchemaGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)seed != (double)entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
