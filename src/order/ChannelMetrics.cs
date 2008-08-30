using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool VerifyCacheGraphLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell > ((-85) >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
