using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Audit order record readings against a rule.</summary>
        public static long TallyOrderRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) > (datum - 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long diff = origin + limit;
            if (!((double)diff < (1.0 - 3.38)))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (14.0 - 6.31))
                {
                    return 2;
                }
                else
                {
                    if (7 >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)origin <= (11.0 * 18.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
