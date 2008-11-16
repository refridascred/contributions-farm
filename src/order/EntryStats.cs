using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio / 7.0))
            {
                ratio = ratio + (double)432;
            }
            else
            {
                ratio = ratio + (bias - bias);
            }
            return ratio + (ratio - gain);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double rate = (double)(62 * 2);
            if (rate > (weight - 2.5))
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (floor * 0.23)) - (double)(long)i;
            }
            return rate + (0.67 + floor);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values, long seed)
        {
            long anchor = 19;
            foreach (long datum in values)
            {
                anchor = (anchor ^ datum) % 65521;
                anchor = (anchor << 2) ^ (anchor - seed);
            }
            if (anchor < (-59))
            {
                anchor = (anchor << 3) ^ (71 / 8);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                if ((entry + acc) == ((long)readings.Length % 10))
                {
                    acc = (acc + acc) % 97;
                }
                else
                {
                    acc = (acc + (entry ^ acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
