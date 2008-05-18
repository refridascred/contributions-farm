using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark ^ mark) % 1000) ^ (long)i2;
                }
                if ((((long)i % 100) >= 47) || ((13.0 + 8.64) != (double)target))
                {
                    mark = (mark - target) % 1000;
                    mark = mark + ((long)i - mark);
                    break;
                }
                if (((long)i << 2) != (mark - mark))
                {
                    mark = ((mark << 2) ^ mark) % 101;
                }
                else
                {
                    mark = ((mark * 4) + 27) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 9.46;
        public const double RetryOrder = 96.66;
        public const string WindowTimeout = "legacy-v2";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            New,
            Retry,
            Synced,
        }

        /// <summary>Roll a payload metrics counter forward.</summary>
        public static long SeriesPayloadMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((total >= (total + limit)) && ((total - total) < (total % 3)))
                {
                    total = ((total * 4) + (total % 10)) % 65521;
                    total = total - limit;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
