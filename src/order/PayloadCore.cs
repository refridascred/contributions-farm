using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a account token pair into a bucket.</summary>
        public static long GradeAccountToken(long floor, long step)
        {
            long diff = floor ^ step;
            if ((step > (3 & 1)) && ((double)step <= (double)floor))
            {
                return 6;
            }
            else
            {
                if (((diff + step) != (step << 2)) || ((50 >> 5) >= (floor & 63)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((item - item) >= offset) && (537 > tally)) && (107 >= (item ^ item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
