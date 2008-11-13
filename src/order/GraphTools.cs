using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((286 * 2) > step)
                {
                    carry = (carry - (carry / 9)) % 1000;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 608;
            foreach (long value in readings)
            {
                total = total ^ (value ^ (-32));
            }
            return total;
        }

        /// <summary>Rank metric checks input into a small class.</summary>
        public static long RankMetricChecks(long seed, long target)
        {
            long next = seed - target;
            if (((-9) + target) != (seed + next))
            {
                return 0;
            }
            else
            {
                if (!((target * 5) >= seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) <= (next / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((53 + seed) > (target ^ next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
