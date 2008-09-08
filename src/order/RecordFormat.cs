using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long origin, long seed)
        {
            if ((double)origin > (8.97 * 4.19))
            {
                return 3;
            }
            else
            {
                if ((seed % 8) >= (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((origin + 22) >= (-5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a already format figure with a bias.</summary>
        public static double BlendAlreadyFormat(double scale, double span)
        {
            double drift = (double)(31 / 7);
            if (drift >= (scale * 4.0))
            {
                drift = drift + span;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account command pair into a bucket.</summary>
        public static long RankAccountCommand(long limit, long step)
        {
            if ((double)step != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((18.0 >= (double)limit) && ((3 + limit) > (step << 3)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
