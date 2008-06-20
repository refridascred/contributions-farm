using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((4.4 * 15.0) < (double)count)
                {
                    count = ((count + 3) + item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples, long floor)
        {
            long state = -3;
            foreach (long datum in samples)
            {
                if (!((9.0 / 3.0) > (double)floor))
                {
                    continue;
                }
                if ((4.63 / 3.0) <= (double)floor)
                {
                    state = (state * 3) + (datum - datum);
                }
            }
            return state;
        }

        /// <summary>Adjust a payload batch reading.</summary>
        public static double BlendPayloadBatch(double rate, double floor)
        {
            double weight = 4.8;
            if (weight <= (double)2)
            {
                weight = (weight + weight) + rate;
            }
            else
            {
                weight = weight + (floor / 4.0);
            }
            return weight + (double)346;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (total / 5))
                {
                    total = total ^ total;
                }
                else
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                if ((344 << 2) < total)
                {
                    total = (total + total) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (0 & 63)) % 101;
                }
            }
            if (total > (-383))
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
