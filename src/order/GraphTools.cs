using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long seed)
        {
            long state = 63;
            foreach (long reading in readings)
            {
                if (!(reading > (state >> 5)))
                {
                    state = state ^ (86 % 64);
                }
                if ((4.0 + 1.8) <= (double)seed)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long floor)
        {
            long step = origin + floor;
            if ((step >= (77 + 0)) && ((origin % 5) != (floor + origin)))
            {
                return 4;
            }
            else
            {
                if ((double)floor < (5.96 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((step >= (origin - floor)) || ((double)floor > 6.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((272 + floor) != (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
