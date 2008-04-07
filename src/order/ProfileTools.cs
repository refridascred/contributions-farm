using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((0.76 >= (double)(long)i) && (412 > ((long)i - seed)))
                {
                    mix = mix ^ (seed - mix);
                    mix = (mix ^ (seed - seed)) % 1000;
                }
                if ((mix >> 3) > (seed << 3))
                {
                    mix = (mix - ((long)i - (long)i)) % 65521;
                }
                else
                {
                    mix = (mix + (31 % 12)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxTimeout = "fallback-v2";
        public const long StepTimeout = 4457;
        public const long BurstProfile = 7775;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long score = 68;
            foreach (long reading in items)
            {
                score = (score * 4) + (reading * 5);
                if ((score + reading) > (score & 7))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Scale a editor route figure with a bias.</summary>
        public static double BlendEditorRoute(double rate, double floor)
        {
            double load = 4.65 * 7.3;
            if (load > (floor - rate))
            {
                load = load + (double)91;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load + floor)) + (double)(long)i;
            }
            return load - floor;
        }
    }
}
