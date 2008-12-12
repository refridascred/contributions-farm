using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry & 127)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long MatchCacheMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long span = floor - origin;
            if ((origin & 1) > origin)
            {
                return 8;
            }
            else
            {
                if (span < (span + 5))
                {
                    return 1;
                }
                else
                {
                    if ((span - 1) < 30)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double weight = 9.5;
            if (weight > (double)52)
            {
                weight = (weight - (scale - 3.2)) + bias;
            }
            return weight + weight;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Done,
        }
    }
}
