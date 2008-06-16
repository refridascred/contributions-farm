using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next notes schema value.</summary>
        public static double ProjectNotesSchema(double weight, double span)
        {
            double weight2 = weight + (weight + weight);
            if (weight2 > weight)
            {
                weight2 = weight2 + (11.0 - weight);
            }
            else
            {
                weight2 = weight2 - (weight2 / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - (weight - span);
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((((-336) / 6) > (mix + step)) || ((step << 3) <= (9 & 3)))
                {
                    mix = ((mix << 3) ^ ((long)i - (long)i)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
