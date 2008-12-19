using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (sum + limit)) % 255) ^ (long)i2;
                    sum = (sum + (limit - limit)) % 255;
                }
                sum = (sum + (limit - (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long bound)
        {
            if (((bound ^ 6) <= (242 >> 4)) || ((double)seed < 13.0))
            {
                return 0;
            }
            else
            {
                if ((7.44 - 5.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (!(((-841) * 4) == (seed & 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
