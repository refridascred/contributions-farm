using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of githubfarm channel readings.</summary>
        public static long MatchGithubfarmChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double load = (rate - rate) * 6.87;
            if (load >= (rate - span))
            {
                load = load - 3.8;
            }
            return load - (double)1;
        }

        /// <summary>Project the next commits batches value.</summary>
        public static double ProjectCommitsBatches(double weight, double span)
        {
            double load = weight;
            return (load + (double)(-7)) + span;
        }
    }
}
