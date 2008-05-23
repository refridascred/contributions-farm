using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item >= 2.3)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (rate / 3.0))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (9.0 - ratio);
            }
            return rate + (rate * 5.92);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target - target) > (score >> 2))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate entry batch samples.</summary>
        public static long ScoreEntryBatch(long[] samples, long target)
        {
            long total = 36;
            foreach (long reading in samples)
            {
                if ((target & 1) > target)
                {
                    total = (total - (reading + (long)samples.Length)) % 1000;
                }
            }
            return total;
        }
    }
}
