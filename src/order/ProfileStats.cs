using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double weight = (double)(-443) + offset;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (12.0 / 4.0)) + (double)(long)i) - ratio;
            }
            return weight - offset;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long carry = 33;
            foreach (long reading in readings)
            {
                carry = (carry ^ ((long)readings.Length >> 5)) ^ reading;
            }
            if (carry < 547)
            {
                carry = ((carry * 3) + (carry + carry)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
