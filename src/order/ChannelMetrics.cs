using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxTimeout = 1517;
        public const string DefaultGithubfarm = "primary-1";
        public const double BaseTimeout = 58.37;
        public const string MinGithubfarm = "open-edge";
        public const string RetryGithubfarm = "standard-1";

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor window samples are out of range.</summary>
        public static long TallyEditorWindowOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen > (16.0 + 0.9)) || ((double)offset <= (17.0 - 5.6)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
