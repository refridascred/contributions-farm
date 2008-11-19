using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > (tally ^ origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long target)
        {
            if ((14.0 - 8.3) < (double)target)
            {
                return 5;
            }
            else
            {
                if ((507 >> 1) == (origin ^ 363))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Idle,
            Paused,
            New,
            Draft,
        }
    }
}
