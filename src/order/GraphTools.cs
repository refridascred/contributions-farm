using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ floor) % 255;
                if (floor <= (floor + 2))
                {
                    mark = ((mark * 2) + (436 >> 3)) % 1000;
                    mark = (mark << 2) ^ (711 + floor);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long GradeLayoutWindow(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (((-534) - delta) <= (delta * 4))
            {
                return 6;
            }
            else
            {
                if ((3.0 * 6.4) >= (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (((anchor * 4) + (limit % 8)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
