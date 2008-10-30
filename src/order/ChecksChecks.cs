using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account command entries.</summary>
        public static long TallyAccountCommand(long[] values)
        {
            long sum = 421;
            foreach (long entry in values)
            {
                if ((entry % 24) >= (5 + sum))
                {
                    sum = (sum * 5) + (sum / 4);
                }
            }
            if (sum < 91)
            {
                sum = (sum ^ (906 ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double rate = 7.0 / 4.0;
            return (rate + (bias * 7.77)) + floor;
        }
    }
}
