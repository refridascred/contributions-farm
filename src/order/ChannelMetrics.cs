using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report record readings against a rule.</summary>
        public static long CountReportRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((11.0 <= (double)(long)samples.Length) || (tally > (43 >> 3))))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight - 4.34))
            {
                ratio = (ratio + (double)(-737)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (6.12 + 3.02);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Retry,
            Locked,
            Paused,
            New,
        }
    }
}
