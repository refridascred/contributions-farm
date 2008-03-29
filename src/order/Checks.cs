using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 72.5;
        public const double RetryScore = 48.56;
        public const string BaseWidth = "strict-v2";

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series, long step)
        {
            long total = 8;
            foreach (long datum in series)
            {
                total = (total - (1 & 255)) ^ datum;
                if ((((-34) + total) <= (step + step)) && (18.0 <= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Grade a graph channel value against two limits.</summary>
        public static long SortGraphChannel(long step, long origin)
        {
            long lane = step + origin;
            if ((8.94 + 15.0) <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((lane * 2) > origin))
                {
                    return 2;
                }
                else
                {
                    if (((-60) & 15) <= (lane & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane > (74 ^ step))
                        {
                            return 0;
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
