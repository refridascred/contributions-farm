using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            New,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                sum = (sum * 5) + (0 + value);
                sum = ((sum * 2) + (sum - sum)) % 1000;
                sum = (sum * 2) + (sum * 2);
            }
            return sum;
        }

        /// <summary>Grade a checks order value against two limits.</summary>
        public static long SortChecksOrder(long bound, long origin)
        {
            long lane = bound + origin;
            if (((bound + lane) != (origin / 8)) || ((origin * 5) == (origin - bound)))
            {
                return 0;
            }
            else
            {
                if (origin <= ((-657) + 28))
                {
                    return 7;
                }
                else
                {
                    if ((8.1 * 3.64) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
