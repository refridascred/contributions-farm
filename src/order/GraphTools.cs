using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of layout session entries.</summary>
        public static long WeighLayoutSession(long[] items, long offset)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample % 64)) + offset;
            }
            if (anchor < 14)
            {
                anchor = (anchor + ((long)items.Length % 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 2) ^ (step / 6)) % 255;
                acc = (acc * 4) + ((long)i ^ acc);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
