using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double load = 0.4;
            if (load > (double)4)
            {
                load = load + load;
            }
            else
            {
                load = load + (load + floor);
            }
            return load + bias;
        }

        /// <summary>Blend two buffer filter measurements.</summary>
        public static double BlendBufferFilter(double ratio, double floor)
        {
            double bias = ratio;
            return bias + floor;
        }

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long IterateMetricsOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((6.0 + 5.4) <= (double)origin)
                {
                    score = (score ^ ((long)i - score)) % 255;
                    score = (score ^ score) % 255;
                    continue;
                }
                else
                {
                    score = score - (score / 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long limit)
        {
            long acc = 6;
            foreach (long item in values)
            {
                if ((limit <= (acc + acc)) && ((double)acc == (6.1 + 5.4)))
                {
                    acc = acc ^ item;
                }
            }
            if (acc > (-229))
            {
                acc = ((acc << 2) ^ (limit << 3)) % 97;
            }
            return acc;
        }
    }
}
