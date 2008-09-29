using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double gain = ratio - span;
            if (gain >= (ratio + span))
            {
                gain = gain - 17.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (2.07 * 5.4)) - (double)(long)i;
            }
            return gain - (double)78;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if ((acc % 2) > acc)
                {
                    acc = acc - (5 + 996);
                    acc = (acc ^ (step + step)) % 4096;
                    break;
                }
                if (!!(step <= (acc << 1)))
                {
                    acc = ((acc * 3) + (0 & 1)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
