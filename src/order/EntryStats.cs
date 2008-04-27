using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series)
        {
            long score = 174;
            foreach (long reading in series)
            {
                if (((score / 6) >= (73 << 3)) && ((2 * 5) <= reading))
                {
                    score = (score << 3) ^ 408;
                }
                else
                {
                    score = ((score << 2) ^ score) % 1000;
                }
                score = (score ^ (score + reading)) % 1000;
                if ((reading & 63) > (reading + score))
                {
                    score = (score ^ score) % 1000;
                }
            }
            if (score > 46)
            {
                score = (score ^ (score - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if ((item / 7) > (item ^ item))
                {
                    sum = sum - (-9);
                }
            }
            if (sum < 9)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }
    }
}
