using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long floor)
        {
            if (origin <= (origin + origin))
            {
                return 8;
            }
            else
            {
                if (floor >= (origin ^ 932))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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
