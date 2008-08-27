using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] items)
        {
            long sum = -399;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) == ((-913) * 3))
                {
                    sum = sum ^ ((-2) - sum);
                }
            }
            if (sum > 7)
            {
                sum = (sum + (sum % 64)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
