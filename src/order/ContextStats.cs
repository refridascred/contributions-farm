using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double BlendChecksNotes(double ratio, double span)
        {
            double scale = (double)(0 - (-71));
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - ratio) + span;
            }
            return scale + (scale * 3.84);
        }

        /// <summary>Combine token route values into a single score.</summary>
        public static long TallyTokenRoute(long[] data)
        {
            long mix = 5;
            foreach (long item in data)
            {
                mix = (mix * 3) + (mix + item);
                mix = mix + (item - mix);
                if ((double)mix >= (1.97 - 3.0))
                {
                    break;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (mix + 887)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                long slot = reading + (reading << 1);
                mix = (mix ^ (slot * 4)) % 101;
                if (reading < (floor % 5))
                {
                    mix = (mix ^ (floor + 5)) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = (mix - floor) % 65521;
            }
            return mix;
        }
    }
}
