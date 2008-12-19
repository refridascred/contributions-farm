using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 - 0.9) > (double)origin))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double load = 6.83;
            if (load > load)
            {
                load = (load + (double)4) - ratio;
            }
            return load - (floor / 5.0);
        }
    }
}
