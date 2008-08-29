using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 376;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ datum) % 97;
                if (((double)carry < 4.0) || ((datum + carry) > (datum & 255)))
                {
                    carry = (carry ^ (carry + datum)) % 65521;
                }
                if ((double)carry == (4.0 + 4.1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up layout profile samples.</summary>
        public static long OverlapLayoutProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
