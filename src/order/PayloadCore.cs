using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((long)values.Length >= seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series, long floor)
        {
            long acc = -25;
            foreach (long cell in series)
            {
                acc = (acc << 3) ^ (floor + cell);
            }
            if (acc > 6)
            {
                acc = acc - (91 & 1);
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (mark / 9)) % 65521;
                mark = ((mark * 4) + (6 % 12)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
