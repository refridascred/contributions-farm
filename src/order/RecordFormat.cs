using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double gain2 = (gain + span) - (span - 7.0);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)3;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long offset)
        {
            if (((bound + bound) != (offset * 2)) && ((double)offset >= (2.91 - 9.0)))
            {
                return 6;
            }
            else
            {
                if ((6.0 * 17.0) == (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (9 >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks payload samples are out of range.</summary>
        public static long CountChecksPayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ cell) >= (matches & 3))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias + (scale * 6.0);
            }
            else
            {
                bias = bias + (1.11 + span);
            }
            return bias + span;
        }
    }
}
