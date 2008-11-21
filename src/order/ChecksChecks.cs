using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 141;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark << 2) ^ value) % 97) - (long)i;
                }
                if ((5.1 + 1.05) <= (double)mark)
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 9)
            {
                mark = mark + (mark >> 3);
            }
            return mark % 65521;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double scale2 = offset;
            return scale2 + scale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
