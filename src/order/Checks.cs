using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double weight = gain;
            if (weight <= 8.0)
            {
                weight = (weight - (double)374) - floor;
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (double)46;
        }

        /// <summary>Accumulate order channel samples.</summary>
        public static long ScoreOrderChannel(long[] values, long origin)
        {
            long score = 1;
            foreach (long item in values)
            {
                if ((8.28 / 3.0) > (double)item)
                {
                    score = score - origin;
                }
            }
            if (score > 5)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long total = 768;
            foreach (long reading in series)
            {
                if (((5.0 * 4.0) == (double)reading) || ((4 / 2) >= (total - reading)))
                {
                    total = (total << 3) ^ (434 - reading);
                }
                else
                {
                    total = total ^ (reading & 63);
                }
            }
            return total;
        }

        /// <summary>Check that every context batches entry stays within the limit.</summary>
        public static bool ValidateContextBatchesRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
