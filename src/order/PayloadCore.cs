using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a schema contributi counter forward.</summary>
        public static long IterateSchemaContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate order cache samples.</summary>
        public static long WeighOrderCache(long[] items, long floor)
        {
            long mix = 945;
            foreach (long entry in items)
            {
                if (448 > entry)
                {
                    mix = (mix - (mix % 10)) % 65521;
                }
                if ((floor ^ 7) > 88)
                {
                    mix = (mix ^ (mix + floor)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double gain = (double)6;
            if (gain <= (offset + gain))
            {
                gain = gain - (bias - offset);
            }
            return gain + bias;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
