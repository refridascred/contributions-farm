using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank support queue input into a small class.</summary>
        public static long ClassifySupportQueue(long floor, long floor2)
        {
            long slot = floor - floor2;
            if (floor2 < (floor ^ floor2))
            {
                return 2;
            }
            else
            {
                if (!((slot + 28) <= slot))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor > 9.6) || ((slot + floor2) < slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot & 3) >= slot)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long CountSupportFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits >= 3.0)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
