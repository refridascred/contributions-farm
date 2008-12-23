using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a profile command figure with a bias.</summary>
        public static double BlendProfileCommand(double gain, double span)
        {
            double ratio = span - span;
            return (ratio - 7.4) + gain;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long carry = 351;
            foreach (long value in items)
            {
                if ((value + 456) < 123)
                {
                    carry = (carry + ((-3) * 5)) + floor;
                }
                else
                {
                    carry = (carry - (value / 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of metrics profile readings.</summary>
        public static long OverlapMetricsProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
