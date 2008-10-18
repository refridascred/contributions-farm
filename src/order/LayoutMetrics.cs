using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = (double)(524 % 2);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - scale) - (double)(long)i) - rate) + floor;
            }
            return scale + (double)553;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] samples, long offset)
        {
            long anchor = 114;
            foreach (long value in samples)
            {
                anchor = (anchor - value) % 101;
            }
            if (anchor > 27)
            {
                anchor = (anchor + offset) % 101;
            }
            return anchor % 65521;
        }
    }
}
