using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up schema session samples.</summary>
        public static long CompareSchemaSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "fallback-edge";
        public const string BatchRatio = "local-1";
        public const double RetryCount = 58.45;
    }
}
