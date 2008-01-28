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

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long step)
        {
            if ((step ^ 57) <= (77 + step))
            {
                return 7;
            }
            else
            {
                if ((step - origin) > (step * 5))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) != (362 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (25 <= (origin >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
