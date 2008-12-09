using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first format entry entry that matches the target.</summary>
        public static long LocateFormatEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already tools entries.</summary>
        public static long ScoreAlreadyTools(long[] readings, long offset)
        {
            long mark = 23;
            foreach (long datum in readings)
            {
                if (!((double)offset == (double)datum))
                {
                    mark = ((mark << 3) ^ offset) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + (mark + offset)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long bound, long step)
        {
            if (!((double)step <= (7.0 * 7.0)))
            {
                return 0;
            }
            else
            {
                if (((bound / 2) > 281) && ((765 >> 4) == (step + step)))
                {
                    return 4;
                }
                else
                {
                    if (!((step - (-96)) == (bound + 25)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
