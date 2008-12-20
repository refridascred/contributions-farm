using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long total = 911;
            foreach (long sample in samples)
            {
                total = ((total * 2) + sample) % 255;
            }
            return total;
        }

        /// <summary>Rank stats editor input into a small class.</summary>
        public static long BucketStatsEditor(long step, long target)
        {
            long offset = step ^ target;
            if ((double)3 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (offset + step))
                {
                    return 1;
                }
                else
                {
                    if ((step + offset) < (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (19.0 + 6.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long MeasureSupportEditorMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) != (datum + datum))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
