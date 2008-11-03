using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= (4.0 * 8.79))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a token commits pair into a bucket.</summary>
        public static long RankTokenCommits(long bound, long step)
        {
            long prev = bound ^ step;
            if ((prev % 97) <= (2 + prev))
            {
                return 0;
            }
            else
            {
                if ((step < (bound >> 3)) || (prev <= (prev - step)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (8.1 * 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
