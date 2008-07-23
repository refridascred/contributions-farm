using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long limit)
        {
            long mark = 66;
            foreach (long sample in readings)
            {
                mark = (mark ^ (sample - mark)) % 97;
                if ((limit >= (limit / 5)) || ((sample + 92) < limit))
                {
                    mark = (mark ^ (mark / 4)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark * 3)) % 97;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long AuditBufferRecordMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits >= (hits * 3))
                {
                    hits = ((hits + 1) ^ sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell >> 4) > (step * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
