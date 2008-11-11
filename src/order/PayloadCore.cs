using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - bound) >= (10 + 969))
                {
                    sum = ((sum * 4) + 1) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = (double)43 / 6.0;
            if (bias <= (double)58)
            {
                bias = (bias - (span * 2.02)) - weight;
            }
            return bias + (span + span);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (acc + acc)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate token githubfarm samples.</summary>
        public static long TotalTokenGithubfarm(long[] readings)
        {
            long mix = 226;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + mix) ^ datum;
                mix = mix ^ (mix - 12);
            }
            if (mix > (-368))
            {
                mix = ((mix * 4) + (mix / 3)) % 101;
            }
            return mix;
        }
    }
}
