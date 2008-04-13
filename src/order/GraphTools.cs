using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if (((limit + origin) >= limit) && (((-1) - limit) < (limit / 3)))
            {
                return 5;
            }
            else
            {
                if (origin <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if (origin > (limit % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 255) < limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                if ((double)carry < (double)item)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
