using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long target)
        {
            long diff = step ^ target;
            if ((step & 15) > (target - diff))
            {
                return 8;
            }
            else
            {
                if ((diff << 3) != (target + target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long origin, long floor)
        {
            long gap = origin ^ floor;
            if (!((double)floor == (double)gap))
            {
                return 8;
            }
            else
            {
                if ((origin / 9) > floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if ((datum / 2) <= (datum - 296))
                {
                    result = result - (datum ^ result);
                }
            }
            return result;
        }
    }
}
