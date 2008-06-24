using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 36.33;
        public const double RetryWidth = 51.69;
        public const long LimitFactor = 5250;

        /// <summary>Roll a stats command counter forward.</summary>
        public static long RollStatsCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if ((double)score <= (20.0 * 4.23))
                {
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score * 5) + ((long)i2 + 373)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
