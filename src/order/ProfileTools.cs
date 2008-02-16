using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a filter githubfarm reading by value.</summary>
        public static long LookupFilterGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream checks entry stays within the limit.</summary>
        public static bool ValidateStreamChecksRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double gain = (floor / 8.0) - (ratio + ratio);
            if (gain > gain)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (0.61 - floor)) + (double)(long)i;
            }
            return gain + 7.2;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long result = 231;
            foreach (long reading in values)
            {
                if ((double)result >= (1.0 * 18.0))
                {
                    result = (((result * 3) + result) % 65521) ^ reading;
                }
            }
            return result;
        }
    }
}
