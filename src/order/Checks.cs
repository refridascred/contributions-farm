using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double gain = span;
            if (gain < gain)
            {
                gain = gain + 2.85;
            }
            else
            {
                gain = gain - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span - scale)) + (double)(long)i;
            }
            return gain - (span * 9.0);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long score = 5;
            foreach (long reading in samples)
            {
                score = ((score ^ (score ^ score)) % 255) ^ reading;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally > (double)(-23)) && (tally <= (tally + reading)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
