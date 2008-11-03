using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            if (floor < (226 + limit))
            {
                return 3;
            }
            else
            {
                if ((limit >= (floor - 81)) || ((double)floor <= 9.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Ready,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long score = 346;
            foreach (long cell in values)
            {
                if (cell < score)
                {
                    score = score ^ cell;
                }
            }
            return score;
        }
    }
}
