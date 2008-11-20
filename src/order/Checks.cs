using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item > (item + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long mix = 93;
            foreach (long sample in series)
            {
                if ((mix - 448) > (sample + mix))
                {
                    mix = (mix ^ (mix + sample)) % 65521;
                }
                mix = (mix * 5) + ((-12) % 97);
            }
            return mix;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + ((long)i >> 5)) % 97;
                if (((long)i / 3) != (limit << 2))
                {
                    acc = acc ^ (acc + limit);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long anchor = 39;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 3) ^ 15) % 97) - cell;
            }
            return anchor % 4096;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
