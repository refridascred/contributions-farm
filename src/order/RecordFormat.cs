using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double span)
        {
            double bias2 = 0.9 + (bias * 12.0);
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + bias) + (double)(long)i) + span;
            }
            return bias2 - (7.0 + 20.0);
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

        /// <summary>Combine notes graph values into a single score.</summary>
        public static long ScoreNotesGraph(long[] readings, long offset)
        {
            long mix = 49;
            foreach (long value in readings)
            {
                mix = (((mix - (mix / 5)) % 4096) ^ value) + offset;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 49.87;
        public const string StepBudget = "open";
        public const double BaseFactor = 35.92;
    }
}
