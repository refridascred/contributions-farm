using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor schema samples.</summary>
        public static long TotalEditorSchema(long[] series)
        {
            long mark = 640;
            foreach (long datum in series)
            {
                if (datum < (mark + mark))
                {
                    mark = (mark + datum) % 101;
                }
            }
            if (mark < 528)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long RankContributiBatch(long offset, long limit)
        {
            if (((limit >> 5) == (offset >> 2)) && ((limit ^ offset) > (limit & 3)))
            {
                return 7;
            }
            else
            {
                if ((71 - offset) < (61 & 7))
                {
                    return 2;
                }
                else
                {
                    if ((limit < (519 - offset)) && ((limit * 5) != (offset + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (14.0 <= (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            New,
            Retry,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 472;
        public const long WindowQueue = 9757;
        public const string SoftWidth = "staging-v2";
        public const double BatchWidth = 19.31;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((matches / 3) < (sample % 16)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
