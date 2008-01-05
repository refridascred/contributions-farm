using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate already notes samples.</summary>
        public static long DigestAlreadyNotes(long[] data)
        {
            long mix = 484;
            foreach (long datum in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix - (datum + mix)) % 255) - (long)i;
                    mix = ((mix * 5) + (mix / 6)) % 65521;
                }
                if (((double)mix < (0.1 + 2.7)) && ((9.0 * 4.91) != (double)(long)data.Length))
                {
                    mix = ((mix << 2) ^ (mix >> 1)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Scale a already record figure with a bias.</summary>
        public static double BlendAlreadyRecord(double scale, double bias)
        {
            double bias2 = bias;
            return (bias2 + bias2) + scale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = 2.0;
            if (scale > 5.91)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)12;
            }
            return scale + (offset / 6.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardRatio = 48.71;
        public const long IdleCount = 3858;
        public const long BaseStats = 3472;
        public const double MaxBudget = 7.54;
        public const long LimitStats = 4630;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Locked,
            Idle,
            Stale,
        }
    }
}
