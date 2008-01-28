using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) < tally)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((9.0 + 5.5) < (double)item)
                {
                    result = ((result * 2) + (item - result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
