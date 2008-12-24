using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double mean = span / 6.0;
            if (mean > span)
            {
                mean = mean + 9.42;
            }
            else
            {
                mean = mean + (span + 5.6);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (span + span)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] items, long floor)
        {
            long sum = 50;
            foreach (long datum in items)
            {
                if (((2 + 161) == (sum & 255)) && ((sum + floor) < (sum << 2)))
                {
                    sum = (sum << 2) ^ (datum / 5);
                }
            }
            return sum;
        }
    }
}
