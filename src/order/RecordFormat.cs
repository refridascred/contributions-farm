using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Done,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a checks editor reading.</summary>
        public static double ProjectChecksEditor(double rate, double bias)
        {
            double drift = (bias - rate) - rate;
            if (drift < 18.0)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift + (bias - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - (bias + rate);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                long step = limit;
                if ((422 > (sum % 64)) || ((double)sum <= 2.4))
                {
                    sum = (sum << 3) ^ limit;
                    sum = (sum << 3) ^ (step >> 1);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double drift = (offset - rate) + (double)45;
            if (drift > rate)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - 1.9;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
