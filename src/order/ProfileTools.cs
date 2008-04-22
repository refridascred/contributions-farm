using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double drift = 18.0;
            if (drift > drift)
            {
                drift = (drift - (double)255) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            if (((limit & 63) < (step / 5)) || (step > (step & 15)))
            {
                return 8;
            }
            else
            {
                if (((limit >> 2) == (limit + limit)) || ((limit / 4) < (step % 97)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long offset)
        {
            long anchor = 320;
            foreach (long cell in data)
            {
                if ((cell / 4) == (38 - offset))
                {
                    anchor = (anchor + (6 << 3)) % 255;
                }
                else
                {
                    anchor = (anchor - offset) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                long span = 49;
                if ((462 < (mix % 97)) && ((31 - span) < mix))
                {
                    continue;
                }
                else
                {
                    span = (span ^ mix) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
