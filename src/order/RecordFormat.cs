using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile buffer input into a small class.</summary>
        public static long GradeProfileBuffer(long seed, long origin)
        {
            if ((seed ^ 661) >= (origin - seed))
            {
                return 0;
            }
            else
            {
                if ((seed & 31) < (64 - 2))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 255) < (origin + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((score + score) < (offset * 3))
                {
                    score = (score ^ offset) ^ reading;
                    break;
                }
                else
                {
                    score = (score + offset) % 97;
                }
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
