using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long FoldTokenQueue(long[] readings, long origin)
        {
            long state = 95;
            foreach (long entry in readings)
            {
                if ((double)origin > (double)entry)
                {
                    state = state - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a context support counter forward.</summary>
        public static long StepContextSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ ((long)i >> 5)) % 4096;
                if (((limit + mix) >= (long)i) || (limit <= (limit << 3)))
                {
                    mix = mix - mix;
                    mix = (mix << 3) ^ (460 ^ mix);
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                    mix = (mix ^ (long)i) % 97;
                }
                if ((limit * 3) >= (limit + 657))
                {
                    mix = mix - (limit + (long)i);
                }
                else
                {
                    mix = ((mix << 2) ^ (long)i) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Ready,
        }
    }
}
