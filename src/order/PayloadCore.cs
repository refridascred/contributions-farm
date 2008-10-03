using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a format schema reading.</summary>
        public static double SmoothFormatSchema(double scale, double span)
        {
            double gain = scale;
            if (gain >= (scale - span))
            {
                gain = gain - 5.2;
            }
            else
            {
                gain = gain - (19.0 - gain);
            }
            return gain + 2.39;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if (11.0 >= (double)sum)
                {
                    sum = ((sum + 12) - value) - bound;
                }
            }
            if (sum < 21)
            {
                sum = ((sum * 5) + (sum >> 5)) % 65521;
            }
            return sum;
        }
    }
}
