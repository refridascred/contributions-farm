using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double rate = scale;
            return rate + (scale - bias);
        }

        /// <summary>Roll a record metric counter forward.</summary>
        public static long SeriesRecordMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] items)
        {
            long total = 12;
            foreach (long value in items)
            {
                total = (total ^ (total / 7)) - value;
            }
            return total;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long target)
        {
            long result = 640;
            foreach (long reading in levels)
            {
                if ((double)result <= (double)22)
                {
                    result = ((result ^ (long)levels.Length) + reading) + target;
                }
            }
            if (result < 16)
            {
                result = result ^ (618 % 10);
            }
            return result;
        }
    }
}
