using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double rate = span;
            if (rate >= (gain * 2.9))
            {
                rate = rate + (gain * 11.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)3) + (double)(long)i;
            }
            return rate + 1.3;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
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
