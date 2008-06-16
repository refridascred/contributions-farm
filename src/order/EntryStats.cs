using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 86.89;
        public const long BurstTimeout = 3498;
        public const double DefaultPayload = 46.69;
        public const long BurstFactor = 1257;
        public const double RetryPayload = 3.09;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long offset)
        {
            long prev = step - offset;
            if ((offset - offset) >= prev)
            {
                return 7;
            }
            else
            {
                if (!((step + offset) > step))
                {
                    return 8;
                }
                else
                {
                    if ((step % 100) == (step / 9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev + prev) == (prev - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "latest-v2";
        public const long WindowBatch = 9537;
        public const string DefaultWidth = "local-edge";
        public const string MinSize = "strict-1";

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9253;
        public const long IdleRatio = 5279;
        public const string RetrySupport = "stable-v2";
    }
}
