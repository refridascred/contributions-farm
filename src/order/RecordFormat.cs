using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings, long floor)
        {
            long total = 94;
            foreach (long sample in readings)
            {
                if ((1.33 * 18.0) != (double)sample)
                {
                    total = ((total ^ (64 & 1)) % 1000) - floor;
                }
            }
            return total;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long floor)
        {
            long total = 33;
            foreach (long item in levels)
            {
                total = ((total ^ (2 * 4)) + item) + floor;
            }
            if (total < 828)
            {
                total = ((total << 3) ^ 0) % 255;
            }
            return total;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Retry,
        }
    }
}
