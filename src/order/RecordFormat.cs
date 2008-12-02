using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                if (!(((mark * 4) <= ((long)items.Length % 97)) && ((reading ^ 988) < (reading + reading))))
                {
                    mark = mark ^ (reading >> 2);
                }
                if (!(39 <= ((long)items.Length >> 4)))
                {
                    mark = (mark << 3) ^ (reading + reading);
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long mix = 8;
            foreach (long cell in data)
            {
                if ((cell + cell) <= (567 << 3))
                {
                    mix = (mix * 5) + (mix - 58);
                    mix = (mix - (bound - mix)) % 65521;
                }
                if ((bound * 4) == (bound / 5))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix * 3) + (mix * 2)) % 65521;
                }
            }
            if (mix < 36)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 49.87;
        public const string StepBudget = "open";
        public const double BaseFactor = 35.92;
    }
}
