using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long step)
        {
            long offset = bound - step;
            if ((double)offset < (3.0 / 8.0))
            {
                return 0;
            }
            else
            {
                if (((double)step >= (double)327) && ((step + 1) <= (step + step)))
                {
                    return 2;
                }
                else
                {
                    if (((5 + bound) <= (offset + offset)) || (2.0 > (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + (-450)) <= (914 & 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session report samples.</summary>
        public static long CombineSessionReport(long[] samples, long bound)
        {
            long acc = 884;
            foreach (long item in samples)
            {
                if (((8.7 + 1.8) >= (double)bound) || ((item & 63) == (acc << 1)))
                {
                    acc = ((acc * 5) + (item - acc)) % 255;
                }
            }
            if (acc > (-26))
            {
                acc = (acc + 0) % 101;
            }
            return acc;
        }
    }
}
