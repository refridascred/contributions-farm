using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                mix = (((mix * 5) + 74) % 97) ^ entry;
            }
            if (mix < (-4))
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            if ((floor + floor) < (floor * 3))
            {
                return 2;
            }
            else
            {
                if ((floor + origin) == (floor - 6))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > floor) && ((floor & 63) < (3 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
