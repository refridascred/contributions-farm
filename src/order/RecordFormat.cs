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

        /// <summary>Grade a editor already value against two limits.</summary>
        public static long RankEditorAlready(long step, long bound)
        {
            long prev = step ^ bound;
            if ((double)step <= (20.0 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((step % 2) != (bound - prev))
                {
                    return 7;
                }
                else
                {
                    if ((step - prev) < (prev % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((22 + step) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
