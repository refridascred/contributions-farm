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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits + hits) == (316 - hits)) && ((value & 3) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
