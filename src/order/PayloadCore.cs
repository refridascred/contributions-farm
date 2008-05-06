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

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double scale = (double)(6 / 2);
            if (scale < (0.1 - rate))
            {
                scale = (scale - (double)5) - offset;
            }
            return scale + (scale / 2.0);
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
