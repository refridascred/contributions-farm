using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftInterval = 6812;
        public const long DefaultChannel = 9068;
        public const double WindowLevel = 83.79;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheRatio = 1988;
        public const long CacheSpan = 8717;
        public const long BurstBatch = 772;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 36.87;
        public const long BaseFarm = 1027;
        public const string MaxFarm = "local-edge";
        public const long WindowFarm = 4361;
        public const string RetryWidth = "cached-1";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload order entries.</summary>
        public static long DigestPayloadOrder(long[] levels)
        {
            long anchor = 82;
            foreach (long item in levels)
            {
                if (anchor < (anchor - anchor))
                {
                    anchor = (anchor ^ item) % 101;
                }
            }
            return anchor;
        }
    }
}
