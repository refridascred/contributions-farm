using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 10;
            foreach (long entry in items)
            {
                if ((double)104 == (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + 34)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (entry * 5)) % 97;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long anchor = -5;
            foreach (long reading in samples)
            {
                if ((double)264 <= (double)reading)
                {
                    anchor = ((anchor * 2) + (765 + reading)) % 255;
                }
                if (((reading + reading) <= (-17)) || (anchor >= 696))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long floor)
        {
            long delta = target + floor;
            if ((double)delta <= 20.0)
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (delta - 49))
                {
                    return 7;
                }
                else
                {
                    if ((9 < (delta & 63)) || ((target / 4) < (target >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6.1 * 8.6) >= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
