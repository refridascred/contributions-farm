using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double rate = span;
            if (rate <= (rate * 8.47))
            {
                rate = (rate - rate) + gain;
            }
            else
            {
                rate = rate + (span * 6.8);
            }
            return rate - 0.6;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
