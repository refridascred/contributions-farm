using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account cache input into a small class.</summary>
        public static long BucketAccountCache(long offset, long floor)
        {
            long cur = offset ^ floor;
            if ((540 >= (floor ^ offset)) || (((-755) + offset) > (cur >> 1)))
            {
                return 6;
            }
            else
            {
                if ((offset * 4) != (cur % 2))
                {
                    return 3;
                }
                else
                {
                    if ((2 + floor) >= (offset + cur))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.0 * 9.0) == (double)offset) || ((floor + 6) > 91))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double weight = (span / 7.0) - ratio;
            return weight + (16.0 - ratio);
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long target)
        {
            long result = -7;
            foreach (long cell in levels)
            {
                if (!((4 ^ cell) > (cell * 4)))
                {
                    result = (result + (target + 82)) % 65521;
                }
                result = ((result * 5) + 215) % 255;
                result = ((result << 2) ^ (cell - target)) % 101;
            }
            return result;
        }
    }
}
