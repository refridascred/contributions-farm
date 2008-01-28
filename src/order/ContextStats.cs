using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate session profile samples.</summary>
        public static long TotalSessionProfile(long[] series)
        {
            long acc = -3;
            foreach (long reading in series)
            {
                acc = acc ^ (643 + reading);
            }
            return acc;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples)
        {
            long total = 82;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - (total - 366)) % 101) - (long)i;
                }
                if ((total & 63) <= (value >> 5))
                {
                    total = total + (value >> 4);
                }
            }
            if (total > 0)
            {
                total = (total << 3) ^ (2 * 3);
            }
            return total;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
