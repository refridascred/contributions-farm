using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((619 / 2) < anchor)
                {
                    anchor = (anchor ^ (22 ^ 3)) % 255;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 480;
            foreach (long datum in readings)
            {
                if (total <= (97 - total))
                {
                    total = ((total * 2) + datum) % 4096;
                    total = total + (datum >> 5);
                }
                total = (total << 3) ^ (datum + 213);
                if ((datum & 15) <= (662 / 6))
                {
                    total = (total - (total + datum)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] series, long step)
        {
            long sum = 513;
            foreach (long item in series)
            {
                if ((step & 7) != (step - sum))
                {
                    sum = ((sum << 3) ^ (item << 1)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a record stream value against two limits.</summary>
        public static long BucketRecordStream(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (2 < seed)
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (double)lane)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double drift = bias;
            return (drift + drift) + floor;
        }
    }
}
