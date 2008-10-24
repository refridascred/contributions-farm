using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] levels)
        {
            long carry = 804;
            foreach (long sample in levels)
            {
                if ((carry << 3) > sample)
                {
                    carry = (carry * 4) + (sample + carry);
                }
                if (!((sample * 3) != (40 + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two cluster already measurements.</summary>
        public static double ProjectClusterAlready(double weight, double span)
        {
            double drift = weight;
            if (drift >= (double)4)
            {
                drift = (drift + (weight * 9.3)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)5) - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Size { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] series, long seed)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if ((2.0 - 5.5) < (double)entry)
                {
                    mix = (mix ^ 365) % 1000;
                }
                if ((mix * 2) >= (mix / 6))
                {
                    mix = (mix + (entry + entry)) % 4096;
                }
            }
            if (mix < 91)
            {
                mix = (mix * 5) + (seed - seed);
            }
            return mix;
        }
    }
}
