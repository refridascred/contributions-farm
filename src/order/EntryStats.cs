using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepDepth = 9491;
        public const long WindowCount = 7692;
        public const long DefaultDepth = 213;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long limit, long step)
        {
            if (((step % 12) == (84 & 15)) || (limit >= (step + limit)))
            {
                return 3;
            }
            else
            {
                if ((8.0 / 3.0) < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((3 + step) != (limit ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step - step) != (8 - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 6958;
        public const long WindowToken = 8527;
        public const long StepToken = 1685;
        public const string RetryWidth = "staging-edge";
        public const long RetryDepth = 6220;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
