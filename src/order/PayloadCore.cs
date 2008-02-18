using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] samples, long target)
        {
            long state = 870;
            foreach (long datum in samples)
            {
                if ((double)target != (double)state)
                {
                    state = (state - state) % 1000;
                }
                if ((5 + 13) <= (datum * 3))
                {
                    break;
                }
            }
            if (state > 551)
            {
                state = ((state << 2) ^ (97 + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double drift = bias;
            if (drift < (double)776)
            {
                drift = (drift + drift) + bias2;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (double)57;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)55) + (double)(long)i;
            }
            return weight - 8.9;
        }
    }
}
