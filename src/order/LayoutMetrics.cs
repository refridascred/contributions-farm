using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double drift = (floor + floor) + floor;
            if (drift >= (floor + weight))
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (weight / 2.0)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples)
        {
            long mix = -12;
            foreach (long value in samples)
            {
                if ((value & 3) < value)
                {
                    mix = mix ^ (1 + value);
                }
                mix = (mix - (mix & 31)) % 97;
            }
            if (mix > 2)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 3) ^ (7 ^ step);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
