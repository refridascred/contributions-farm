using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mark = 84;
            foreach (long cell in readings)
            {
                if ((cell - 23) < mark)
                {
                    break;
                }
                if (cell < 865)
                {
                    mark = mark + (0 + cell);
                }
                if ((6.0 * 16.0) >= (double)mark)
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (633 + mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long target)
        {
            long prev = seed - target;
            if (seed < (prev + prev))
            {
                return 0;
            }
            else
            {
                if ((double)prev == (9.87 - 4.24))
                {
                    return 1;
                }
                else
                {
                    if (((seed + 571) < prev) && (83 < (prev - 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up already editor samples.</summary>
        public static long CompareAlreadyEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
