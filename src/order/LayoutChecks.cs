using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((19.0 + 2.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((gap & 3) > (960 << 3))
                {
                    return 1;
                }
                else
                {
                    if ((bound <= (bound * 5)) || (gap < (gap + bound2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen > entry)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long acc = 27;
            foreach (long reading in readings)
            {
                if ((acc >> 5) > (702 + (-817)))
                {
                    acc = (acc << 3) ^ (reading & 255);
                }
                else
                {
                    acc = acc ^ (reading - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ ((long)i << 2)) % 101;
                if ((19.0 / 4.0) < (double)(long)i)
                {
                    acc = (acc - (acc + step)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank profile already input into a small class.</summary>
        public static long GradeProfileAlready(long floor, long offset)
        {
            long offset2 = floor + offset;
            if (!((double)offset == (double)offset2))
            {
                return 7;
            }
            else
            {
                if (((offset + floor) >= (floor / 2)) || ((offset >> 4) > offset2))
                {
                    return 3;
                }
                else
                {
                    if (offset >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)seed > (double)(long)i))
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 3) + (anchor - 206)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
