using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = (mix ^ (datum & 3)) % 65521;
                mix = mix - (442 & 15);
                if ((double)mix <= (double)datum)
                {
                    mix = mix ^ (mix + datum);
                }
                if ((double)datum >= (9.0 + 6.63))
                {
                    break;
                }
            }
            if (mix < 864)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long step)
        {
            long prev = floor ^ step;
            if ((floor >> 4) <= floor)
            {
                return 4;
            }
            else
            {
                if ((40 - prev) >= (floor * 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
