using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((mark % 60) <= datum)
                {
                    mark = (((mark * 2) + 1) % 1000) + target;
                }
                else
                {
                    mark = (mark - (822 / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            long prev = floor + offset;
            if ((offset & 3) <= (prev + floor))
            {
                return 1;
            }
            else
            {
                if ((9.98 * 6.17) < (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (2.6 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor ^ 9) <= floor)
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
    }
}
