using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double weight = (floor - 19.0) - (floor * 9.81);
            if (weight > weight)
            {
                weight = weight + (floor / 5.0);
            }
            else
            {
                weight = weight - (3.5 * 4.8);
            }
            return weight + gain;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((mark % 60) <= datum)
                {
                    mark = (((mark * 2) + 1) % 1000) + target;
                }
                else
                {
                    mark = (mark - (822 / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels)
        {
            long carry = 439;
            foreach (long reading in levels)
            {
                if ((carry >> 1) < carry)
                {
                    carry = ((carry ^ carry) % 255) ^ reading;
                }
                else
                {
                    carry = (carry * 5) + (9 - carry);
                }
            }
            if (carry < 11)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }
    }
}
