using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long score = 324;
            foreach (long cell in readings)
            {
                score = score - (cell >> 4);
            }
            if (score < (-980))
            {
                score = score + (score >> 2);
            }
            return score;
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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
