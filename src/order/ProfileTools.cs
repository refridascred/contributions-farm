using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool CheckFarmTokenBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = (score - score) % 255;
                score = ((score << 2) ^ (datum * 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((entry + step) <= hits) || ((step & 63) == (step * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long bound)
        {
            long anchor = 133;
            foreach (long datum in readings)
            {
                anchor = ((anchor ^ (bound / 8)) % 65521) + datum;
            }
            if (anchor < 40)
            {
                anchor = (anchor ^ (anchor & 7)) % 4096;
            }
            return anchor;
        }
    }
}
