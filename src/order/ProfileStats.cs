using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a queue window reading by value.</summary>
        public static long SeekQueueWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)(-592))
            {
                ratio2 = (ratio2 + ratio2) + offset;
            }
            return ratio2 + (0.6 + ratio);
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally == (19.0 * 9.1))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
