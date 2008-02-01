using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((origin - seen) < (reading << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up command window samples.</summary>
        public static long PairCommandWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next window route value from a seed.</summary>
        public static long DeriveWindowRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result - seed) ^ (long)i2;
                }
                result = (result - (result - seed)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long origin)
        {
            if (((step >> 4) != (origin >> 3)) && ((double)origin > (8.18 - 5.0)))
            {
                return 0;
            }
            else
            {
                if (origin > (step + origin))
                {
                    return 6;
                }
                else
                {
                    if ((step % 5) <= (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (9.0 * 2.49))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
