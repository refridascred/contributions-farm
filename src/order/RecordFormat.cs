using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 7;
            foreach (long entry in levels)
            {
                if ((mix & 7) <= (entry + entry))
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 101;
                }
            }
            return mix % 4096;
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
