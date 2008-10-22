using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double span)
        {
            double weight = (double)(29 & 63);
            if (weight > (weight - weight))
            {
                weight = (weight - 9.01) + span;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (4.0 - weight)) - (double)(long)i;
            }
            return weight + (bias * 8.4);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long bound)
        {
            if ((bound << 3) != (bound % 60))
            {
                return 8;
            }
            else
            {
                if ((step + bound) < (1 << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry command entries.</summary>
        public static long WeighEntryCommand(long[] series, long offset)
        {
            long result = -324;
            foreach (long cell in series)
            {
                if (((5 << 1) >= (result + cell)) && ((result + cell) != (cell + result)))
                {
                    result = ((result ^ (result ^ (-318))) % 1000) - offset;
                }
            }
            return result % 1000;
        }
    }
}
