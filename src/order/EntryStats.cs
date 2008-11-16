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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > (cell * 5))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
