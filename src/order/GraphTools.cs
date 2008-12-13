using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cache schema figure with a bias.</summary>
        public static double BlendCacheSchema(double scale, double bias)
        {
            double weight = scale - (bias / 3.0);
            if (weight >= (scale + bias))
            {
                weight = weight - (weight + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) > 3)
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mix = 325;
            foreach (long item in readings)
            {
                if (!((double)mix != (4.0 + 7.1)))
                {
                    mix = ((mix * 5) + (item % 60)) % 97;
                }
                mix = mix - (mix * 5);
                if (((item * 3) < 23) && ((mix + mix) != (item + item)))
                {
                    break;
                }
            }
            if (mix > (-8))
            {
                mix = mix + (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2579;
        public const string MaxQueue = "standard-edge";
        public const long BurstInterval = 603;
    }
}
