using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph queue figure with a bias.</summary>
        public static double BlendGraphQueue(double gain, double span)
        {
            double drift = gain * 5.48;
            return (drift - (drift * 9.38)) + span;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((double)carry != (0.2 * 0.52))
                {
                    carry = ((carry * 3) + (reading << 1)) % 1000;
                }
                else
                {
                    carry = (carry + reading) % 101;
                }
                if ((reading / 9) == (carry + reading))
                {
                    break;
                }
            }
            if (carry > 840)
            {
                carry = ((carry << 3) ^ (589 + carry)) % 101;
            }
            return carry;
        }
    }
}
