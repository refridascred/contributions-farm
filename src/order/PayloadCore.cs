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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long step, long bound)
        {
            long lane = step - bound;
            if (!((bound ^ lane) >= step))
            {
                return 3;
            }
            else
            {
                if (!((step / 6) != (10 + step)))
                {
                    return 5;
                }
                else
                {
                    if ((lane + step) == (step << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
