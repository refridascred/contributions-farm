using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Ready,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long TallyMetricNotesHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((6.0 + 6.4) >= (double)floor)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Draft,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((offset - (long)i) == (mix - offset)) || ((long)i < mix))
                {
                    mix = (mix - mix) % 65521;
                    mix = mix ^ (offset >> 2);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + (mix % 100)) % 4096) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value < (20.0 * 8.21))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
