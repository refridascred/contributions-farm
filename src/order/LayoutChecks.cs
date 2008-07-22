using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor + (anchor ^ (long)i2)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long score = 86;
            foreach (long entry in values)
            {
                if (!(1.42 < (double)entry))
                {
                    score = ((score * 2) + (entry % 8)) % 4096;
                }
                score = (score ^ (score & 127)) % 4096;
                if ((entry * 3) < (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long seed)
        {
            long total = 869;
            foreach (long reading in samples)
            {
                if (((seed * 3) > (total / 4)) && ((reading - seed) >= (225 + seed)))
                {
                    total = (total + seed) % 65521;
                }
                if (seed >= (total / 2))
                {
                    total = ((total * 2) + (reading + 292)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (561 % 8)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
