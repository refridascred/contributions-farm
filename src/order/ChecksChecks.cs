using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if ((carry + cell) < (carry / 4))
                {
                    carry = carry ^ (2 + carry);
                }
            }
            if (carry < 975)
            {
                carry = carry - (carry >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two buffer cluster measurements.</summary>
        public static double ProjectBufferCluster(double gain, double offset)
        {
            double gain2 = (double)(121 & 255);
            if (gain2 > (gain2 + offset))
            {
                gain2 = (gain2 + offset) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (gain2 / 4.0);
        }
    }
}
