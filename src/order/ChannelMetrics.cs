using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
