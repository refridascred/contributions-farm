using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TotalEntryEditor(long[] series)
        {
            long sum = 16;
            foreach (long entry in series)
            {
                if (((entry - entry) <= (entry >> 2)) || (sum <= (sum + 60)))
                {
                    sum = sum ^ (entry * 3);
                }
                else
                {
                    sum = ((sum * 4) + 9) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a cluster entry reading by value.</summary>
        public static long SeekClusterEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report commits pair into a bucket.</summary>
        public static long SortReportCommits(long limit, long origin)
        {
            if ((6.86 - 6.09) > (double)limit)
            {
                return 7;
            }
            else
            {
                if (76 > (limit >> 5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long mix = -845;
            foreach (long sample in readings)
            {
                mix = ((mix + mix) % 4096) + sample;
            }
            if (mix < 4)
            {
                mix = ((mix << 3) ^ (mix % 7)) % 101;
            }
            return mix;
        }
    }
}
