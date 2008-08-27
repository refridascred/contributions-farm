using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc * 2) + ((long)i >> 5);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool GuardNotesEditorRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long limit)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                if ((limit * 4) > (limit - 443))
                {
                    score = (score ^ (sample % 12)) % 65521;
                }
                else
                {
                    score = score + limit;
                }
                if ((7.48 - 3.03) < (double)sample)
                {
                    break;
                }
            }
            return score;
        }
    }
}
