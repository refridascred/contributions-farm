using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double rate = (double)((-368) & 3);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate + (span + rate);
        }

        /// <summary>Grade a layout stats value against two limits.</summary>
        public static long SortLayoutStats(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((247 + floor2) > edge)
            {
                return 6;
            }
            else
            {
                if (!((floor2 + floor2) <= floor2))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 * 5) < edge)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxFactor = 37.82;
        public const long BaseCounter = 3526;
        public const long MaxWidth = 8096;
        public const long HardCounter = 4202;
        public const long IdleCounter = 8997;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                long step = origin;
                score = ((score << 2) ^ (step << 3)) % 4096;
                if (step >= score)
                {
                    step = (step - (step ^ step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
