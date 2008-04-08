using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a queue cluster pair into a bucket.</summary>
        public static long GradeQueueCluster(long bound, long origin)
        {
            if ((origin + bound) < (bound * 4))
            {
                return 8;
            }
            else
            {
                if ((5.84 * 0.41) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long offset)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                if (!(acc > (datum << 2)))
                {
                    acc = (acc * 3) + (acc - 9);
                }
                if (((double)acc >= (11.0 + 6.0)) && ((offset >> 3) >= acc))
                {
                    acc = acc - (offset - 53);
                }
                else
                {
                    acc = (acc << 3) ^ (offset & 1);
                }
            }
            return acc;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
