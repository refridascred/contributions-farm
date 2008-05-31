using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 69.58;
        public const long BurstLevel = 2402;
        public const double BatchOrder = 5.05;
        public const long HardOrder = 3541;

        /// <summary>Derive the next window payload value from a seed.</summary>
        public static long RollWindowPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)21 >= (double)(long)i)
                {
                    anchor = (anchor * 5) + (anchor % 24);
                }
                anchor = ((anchor << 3) ^ step) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + (step + total);
                total = (total ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Ready,
            Done,
            Stale,
        }
    }
}
