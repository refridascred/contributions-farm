using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items, long seed)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = score ^ (sample + seed);
            }
            if (score > 595)
            {
                score = score ^ seed;
            }
            return score;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a filter queue value against two limits.</summary>
        public static long ClassifyFilterQueue(long floor, long bound)
        {
            long gap = floor - bound;
            if ((floor + floor) > gap)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (bound % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)gap <= (18.0 + 0.5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((bound >> 4) <= seen) && ((bound ^ bound) >= seen))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
