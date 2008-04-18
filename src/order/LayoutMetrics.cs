using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long sum = 1;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum * 2) + reading) % 65521;
                    sum = sum + ((long)i << 2);
                }
                sum = (sum ^ (reading / 5)) % 1000;
            }
            if (sum > (-912))
            {
                sum = (sum * 5) + (sum >> 5);
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
