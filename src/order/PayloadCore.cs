using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a stream profile reading by value.</summary>
        public static long LocateStreamProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue checks readings.</summary>
        public static long ScoreQueueChecks(long[] levels)
        {
            long acc = -649;
            foreach (long datum in levels)
            {
                if (!((acc >= datum) || ((20.0 * 1.18) != (double)datum)))
                {
                    acc = acc - (acc ^ datum);
                }
                acc = ((acc << 3) ^ (datum + acc)) % 1000;
                if ((datum - (long)levels.Length) != (acc + acc))
                {
                    break;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 3) ^ (acc << 1)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 9310;
        public const long BatchEditor = 4509;
        public const double StepEditor = 9.42;
        public const long MinEditor = 9199;
        public const string DefaultRatio = "legacy";

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                if (((datum + mark) == (mark >> 5)) || ((double)datum > (4.1 - 2.0)))
                {
                    mark = (mark << 3) ^ (datum - 828);
                }
                else
                {
                    mark = mark + (mark >> 2);
                }
            }
            return mark;
        }
    }
}
