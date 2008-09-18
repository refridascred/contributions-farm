using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data)
        {
            long score = 90;
            foreach (long value in data)
            {
                if (((value >> 5) > ((-379) + 990)) || ((value + score) < ((long)data.Length + score)))
                {
                    score = (score - (score + value)) % 65521;
                }
                if (((value / 6) > value) && ((double)35 == (double)value))
                {
                    score = (score << 3) ^ (value * 2);
                }
                else
                {
                    score = ((score * 4) + (value - 0)) % 65521;
                }
                if ((score <= (value + value)) || ((score % 60) <= (score + value)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double drift = (double)(78 ^ 56);
            if (drift >= drift)
            {
                drift = ((drift + drift) - scale) - bias;
            }
            return drift - (double)36;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long score = -31;
            foreach (long entry in items)
            {
                if ((entry - score) != (entry + entry))
                {
                    score = (score << 3) ^ entry;
                }
            }
            if (score > 897)
            {
                score = (score + ((-267) % 3)) % 255;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double load = floor;
            if (load >= (double)0)
            {
                load = (load + floor) + weight;
            }
            else
            {
                load = load - 12.0;
            }
            return load + (7.5 / 4.0);
        }
    }
}
