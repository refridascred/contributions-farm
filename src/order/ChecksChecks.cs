using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
