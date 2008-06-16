using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Pending,
            Synced,
            Failed,
            Draft,
        }

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
