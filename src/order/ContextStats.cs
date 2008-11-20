using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((mix >> 5) != (4 + 790))
                {
                    mix = mix ^ floor;
                }
                else
                {
                    mix = (mix + (floor + 847)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Idle,
            New,
            Ready,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double offset)
        {
            double weight = 8.0;
            if (weight > (bias * 4.1))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (weight - offset);
            }
            return weight + weight;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
