using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 66;
            foreach (long cell in series)
            {
                mix = (mix << 2) ^ (cell % 5);
            }
            if (mix > (-1))
            {
                mix = ((mix * 4) + ((long)series.Length - mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = (double)28 * 3.1;
            if (weight > (15.0 - weight))
            {
                weight = ((weight - (double)88) - scale) + span;
            }
            return weight - (double)51;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry + (long)i;
                carry = (carry - ((long)i % 3)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
