using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 2) ^ ((long)i2 % 12)) % 1000;
                    sum = (sum ^ limit) % 97;
                }
                sum = sum + ((long)i + limit);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((lane + origin) >= origin)
            {
                return 1;
            }
            else
            {
                if ((lane - lane) <= (lane ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((29 - 17) >= bound) || ((double)lane <= 0.1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - bound) >= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= 20.0)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.0 / 5.0) < (double)reading)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
