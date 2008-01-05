using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long CountTokenReportGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (7.6 + 9.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((0.89 / 7.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit - (-789)) == (floor ^ span))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ floor) >= (limit + 151))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor == (double)span)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
