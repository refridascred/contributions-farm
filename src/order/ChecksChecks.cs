using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 5) + (step / 6);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double scale2 = offset;
            return scale2 + scale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings, long offset)
        {
            long acc = 779;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc << 3) ^ ((long)i % 3);
                    acc = (acc * 3) + (entry + offset);
                }
                acc = (acc + (offset - acc)) % 1000;
            }
            if (acc < 5)
            {
                acc = (acc ^ (acc - acc)) % 4096;
            }
            return acc % 4096;
        }
    }
}
