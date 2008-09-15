using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long TallyCounterGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((3.73 - 13.0) < (double)count) && ((long)samples.Length >= step)) || ((6.0 * 2.9) < (13.0 + 7.7)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
